namespace EducationalPlans.Domain 
{
 public class ПланыСтроки 
{
public System.String id { get; set; }
public System.Int32 rowOrder { get; set; }
public System.String hasChanges { get; set; }
public System.Int32 Код { get; set; }
public System.Int32 КодПлана { get; set; }
public System.Int32 КодООП { get; set; }
public System.Int32 КодБлока { get; set; }
public System.Int32 КодКафедры { get; set; }
public System.String Дисциплина { get; set; }
public System.Int32 ТипОбъекта { get; set; }
public System.Int32 ВидОбъекта { get; set; }
public System.Boolean РассредПрактика { get; set; }
public System.Int32 УровеньВложения { get; set; }
public System.Boolean ПризнакФизкультуры { get; set; }
public System.Boolean СчитатьБезЗЕТ { get; set; }
public System.Boolean СчитатьВПлане { get; set; }
public System.Boolean НеСчитатьКонтроль { get; set; }
public System.Boolean ЗаСчетПолевых { get; set; }
public System.String ДисциплинаКод { get; set; }
public System.Int32 ТрудоемкостьКредитов { get; set; }
public System.Int32 ЧасовВЗЕТ { get; set; }
public System.Int32 ЗЕТфакт { get; set; }
public System.Int32 ЗЕТизучено { get; set; }
public System.Int32 ЧасовПоЗЕТ { get; set; }
public System.Int32 ЧасовПоПлану { get; set; }
public System.Int32 ПодлежитИзучениюЧасов { get; set; }
public System.Boolean НестандартНедПрактики { get; set; }
public System.Boolean ReadOnly { get; set; }
public System.Boolean Свернуть { get; set; }
public System.Int32 Multiselect { get; set; }
public System.Int32 Оценка { get; set; }
public System.Int32 ТипПерезачета { get; set; }
public System.Boolean Адаптационная { get; set; }
}
}