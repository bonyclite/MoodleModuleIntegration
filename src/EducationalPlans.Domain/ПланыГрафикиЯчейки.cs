namespace EducationalPlans.Domain 
{
 public class ПланыГрафикиЯчейки 
{
public System.String id { get; set; }
public System.Int32 rowOrder { get; set; }
public System.String hasChanges { get; set; }
public System.Int32 Код { get; set; }
public System.Int32 КодГрафика { get; set; }
public System.Int32 КодВидаДеятельности { get; set; }
public System.Int32 НомерНедели { get; set; }
public System.Int32 НомерЧастиНедели { get; set; }
public System.Int32 Курс { get; set; }
public System.Int32 Семестр { get; set; }
public System.Boolean Переаттестована { get; set; }
public System.Int32 КоличествоЧастейВНеделе { get; set; }
public System.Int32 НомерПервойНедели { get; set; }
}
}