using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using EducationalPlans.Domain;

namespace EducationalPlans.Parser.Api.Services
{
    public interface IXmlFileParserService
    {
        void SetFilePath(string xmlFilePath);
        IEnumerable<TBaseModel> GetFileRecords<TBaseModel>() where TBaseModel : BaseModel, new();
    }

    public class XmlFileParserService : IXmlFileParserService
    {
        private string _xmlFilePath;

        public void SetFilePath(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
        }

        public IEnumerable<TBaseModel> GetFileRecords<TBaseModel>() where TBaseModel : BaseModel, new()
        {
            var xDocument = Load();

            var result = new List<TBaseModel>();

            if (xDocument.Root != null)
            {
                var xElements = xDocument.Root.DescendantNodes().OfType<XElement>()
                    .Where(x => x.Name.LocalName == typeof(TBaseModel).Name)
                    .ToArray();

                foreach (var xElement in xElements)
                {
                    var model = new TBaseModel();

                    var xElementAttributes = xElement.Attributes();
                    var modelProperties = model.GetType().GetProperties();

                    foreach (var propertyInfo in modelProperties)
                    {
                        var xAttribute = xElementAttributes.FirstOrDefault(x => x.Name.LocalName == propertyInfo.Name);

                        if (xAttribute != null)
                        {
                            if (int.TryParse(xAttribute.Value, out var intResult))
                                propertyInfo.SetValue(model, intResult);
                            else if (bool.TryParse(xAttribute.Value, out var boolResult))
                                propertyInfo.SetValue(model, boolResult);
                            else
                                propertyInfo.SetValue(model, xAttribute.Value);
                        }
                    }

                    result.Add(model);
                }
            }
            else
                throw new ArgumentNullException(nameof(xDocument.Root));

            return result;
        }

        private XDocument Load()
        {
            return XDocument.Load(_xmlFilePath);
        }
    }
}