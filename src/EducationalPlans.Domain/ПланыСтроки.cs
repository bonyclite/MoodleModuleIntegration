namespace EducationalPlans.Domain
{
    public class ПланыСтроки
    {
        public string id { get; set; }
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public int КодПлана { get; set; }
        public int КодООП { get; set; }
        public int КодБлока { get; set; }
        public int КодКафедры { get; set; }
        public int КодРодителя { get; set; }
        public string Дисциплина { get; set; }
        public int ТипОбъекта { get; set; }
        public int ВидОбъекта { get; set; }
        public bool РассредПрактика { get; set; }
        public int УровеньВложения { get; set; }
        public bool ПризнакФизкультуры { get; set; }
        public bool СчитатьБезЗЕТ { get; set; }
        public bool СчитатьВПлане { get; set; }
        public bool НеСчитатьКонтроль { get; set; }
        public bool ЗаСчетПолевых { get; set; }
        public string ДисциплинаКод { get; set; }
        public int ТрудоемкостьКредитов { get; set; }
        public int ЧасовВЗЕТ { get; set; }
        public int ЗЕТфакт { get; set; }
        public int ЗЕТизучено { get; set; }
        public int ЧасовПоЗЕТ { get; set; }
        public int ЧасовПоПлану { get; set; }
        public int ПодлежитИзучениюЧасов { get; set; }
        public bool НестандартНедПрактики { get; set; }
        public bool ReadOnly { get; set; }
        public bool Свернуть { get; set; }
        public int Multiselect { get; set; }
        public int Оценка { get; set; }
        public int ТипПерезачета { get; set; }
        public bool Адаптационная { get; set; }
    }
}