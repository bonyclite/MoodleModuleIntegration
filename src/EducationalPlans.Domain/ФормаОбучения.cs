using System.Xml.Serialization;

namespace EducationalPlans.Domain
{
    public class ФормаОбучения : BaseModel {
        public int rowOrder { get; set; }
        public int Код { get; set; }

        [XmlAttribute("ФормаОбучения")]
        public string Форма { get; set; }

        public string Сокращение { get; set; }
        public bool Вывод { get; set; }
        public string Префикс { get; set; }
    }
}