using System.Xml.Serialization;

namespace EducationalPlans.Domain
{
    public class ФормаОбучения
    {
        public System.String id { get; set; }
        public System.Int32 rowOrder { get; set; }
        public System.Int32 Код { get; set; }
        [XmlAttribute("ФормаОбучения")]
        public System.String Форма { get; set; }
        public System.String Сокращение { get; set; }
        public System.Boolean Вывод { get; set; }
        public System.String Префикс { get; set; }
    }
}