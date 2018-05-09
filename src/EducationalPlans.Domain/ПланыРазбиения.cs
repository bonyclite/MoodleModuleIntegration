namespace EducationalPlans.Domain 
{
 public class ПланыРазбиения 
{
public System.String id { get; set; }
public System.Int32 rowOrder { get; set; }
public System.String hasChanges { get; set; }
public System.Int32 Код { get; set; }
public System.Int32 КодПланыНовыеЧасы { get; set; }
public System.Int32 КодКафедры { get; set; }
public System.Int32 Недель { get; set; }
public System.Int32 Дней { get; set; }
public System.Int32 КоличествоСтудентов { get; set; }
public System.Boolean Суммировать { get; set; }
public System.Int32 НормативНаСтуд { get; set; }
public System.Int32 НормативНаСтудВНед { get; set; }
public System.Int32 НормативНаПодгр { get; set; }
public System.Int32 НормативНаПодгрВНед { get; set; }
public System.String Наименование { get; set; }
public System.Int32 НомерКомиссии { get; set; }
public System.String Преподаватель { get; set; }
}
}