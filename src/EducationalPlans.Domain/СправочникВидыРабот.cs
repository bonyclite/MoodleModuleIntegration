namespace EducationalPlans.Domain 
{
 public class СправочникВидыРабот 
{
public System.String id { get; set; }
public System.Int32 rowOrder { get; set; }
public System.String hasChanges { get; set; }
public System.Int32 Код { get; set; }
public System.String Название { get; set; }
public System.Int32 КодТипРабот { get; set; }
public System.String Аббревиатура { get; set; }
public System.Boolean Контактный { get; set; }
public System.Boolean Аудиторный { get; set; }
public System.Boolean Отображать { get; set; }
public System.Boolean HasInter { get; set; }
public System.Boolean HasDistr { get; set; }
}
}