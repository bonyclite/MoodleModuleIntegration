namespace EducationalPlans.Domain 
{
 public class ПланыНовыеЧасы 
{
public System.String id { get; set; }
public System.Int32 rowOrder { get; set; }
public System.String hasChanges { get; set; }
public System.Int32 Код { get; set; }
public System.Int32 КодОбъекта { get; set; }
public System.Int32 КодВидаРаботы { get; set; }
public System.Int32 КодТипаЧасов { get; set; }
public System.Int32 Курс { get; set; }
public System.Int32 Семестр { get; set; }
public System.Int32 Сессия { get; set; }
public System.Int32 Недель { get; set; }
public System.Int32 Дней { get; set; }
public System.Int32 Количество { get; set; }
public System.Boolean Переаттестовано { get; set; }
public System.Int32 ТипКомиссии { get; set; }
}
}