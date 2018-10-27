using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EducationalPlans.DomainModelsGenerator
{
    internal class DomainModelsGenerator
    {
        private readonly string _xmlFilePath;
        private readonly string _filesLocation;

        private readonly List<string> _addedClasses;

        public DomainModelsGenerator(string xmlFilePath, string filesLocation)
        {
            _xmlFilePath = xmlFilePath;
            _filesLocation = filesLocation;
            _addedClasses = new List<string>();
        }

        public void Generate()
        {
            var xElements = LoadDocumentAndGetElements();

            foreach (var xElement in xElements)
            {
                SearchElementsAndGenerateModel(xElement);
            }
        }

        private IEnumerable<XElement> LoadDocumentAndGetElements()
        {
            var xDocument = XDocument.Load(_xmlFilePath);

            return xDocument.Elements();
        }

        private void SearchElementsAndGenerateModel(XElement xElement)
        {
            var xElements = xElement.Elements().OrderByDescending(element => element.Attributes().Count());

            foreach (var element in xElements)
            {
                if (element.HasElements)
                    SearchElementsAndGenerateModel(element);
                else
                {
                    var className = element.Name.LocalName;

                    if (!_addedClasses.Contains(className))
                    {
                        _addedClasses.Add(className);

                        var attributes = element.Attributes();
                        var properties = new List<string>();

                        foreach (var xAttribute in attributes)
                        {
                            var propertyName = xAttribute.Name.LocalName;

                            if (int.TryParse(xAttribute.Value, out var _))
                                properties.Add(GetPropertyString<int>(propertyName));
                            else if (bool.TryParse(xAttribute.Value, out var _))
                                properties.Add(GetPropertyString<bool>(propertyName));
                            else
                                properties.Add(GetPropertyString<string>(propertyName));
                        }

                        var classString = GetClassString(element.Name.LocalName, properties);
                        CreateFile($"{className}.cs", classString);
                    }
                }
            }
        }

        private void CreateFile(string fileNameWithExt, string fileContent)
        {
            using (var fileStream = File.Create($@"{_filesLocation}\{fileNameWithExt}"))
            {
                var info = new UTF8Encoding(true).GetBytes(fileContent);
                fileStream.Write(info, 0, info.Length);
            }
        }

        private string GetPropertyString<TValue>(string name)
        {
            return "public " + typeof(TValue) + " " + name + " { get; set; }";
        }

        private string GetClassString(string className, List<string> properties)
        {
            var join = string.Join("", properties.Select(p => p + $"{Environment.NewLine}"));

            return $"namespace EducationalPlans.Domain.New {Environment.NewLine}" + "{" +
                   $"{Environment.NewLine} public class {className} {Environment.NewLine}" + "{" + Environment.NewLine +
                   join + "}" + Environment.NewLine + "}";
        }
    }
}