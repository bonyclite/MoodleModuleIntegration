namespace EducationalPlans.Domain 
{
 public class Планы 
{
public System.String id { get; set; }
public System.Int32 rowOrder { get; set; }
public System.String hasChanges { get; set; }
public System.Int32 Код { get; set; }
public System.String УчебныйГод { get; set; }
public System.Int32 КодООП { get; set; }
public System.Int32 КодФормыОбучения { get; set; }
public System.Int32 КодОрганизации { get; set; }
public System.Int32 КодФакультета { get; set; }
public System.Boolean Сокращённое { get; set; }
public System.Boolean Дистанционное { get; set; }
public System.Boolean ДляИностранных { get; set; }
public System.String Титул { get; set; }
public System.String Квалификация { get; set; }
public System.String Специализация { get; set; }
public System.String ВоеннаяСпециальность { get; set; }
public System.String Предназначение { get; set; }
public System.Int32 СрокОбучения { get; set; }
public System.Int32 СрокОбученияМесяцев { get; set; }
public System.Int32 ЧислоКурсов { get; set; }
public System.Int32 ЧислоСессий { get; set; }
public System.Int32 КодГрафика { get; set; }
public System.Int32 НомерФГОС { get; set; }
public System.String ДатаГОСа { get; set; }
public System.String ДатаВерсииПриложения { get; set; }
public System.Int32 НомерВерсииПриложения { get; set; }
public System.String ИмяПриложения { get; set; }
public System.Int32 НомерПользователя { get; set; }
public System.String ИмяПользователя { get; set; }
public System.String ИмяФайла { get; set; }
public System.String ДатаИзмФайла { get; set; }
public System.String ДатаУтверСоветом { get; set; }
public System.Int32 НомПротокСовета { get; set; }
public System.String Примечание { get; set; }
public System.Int32 ГодНачалаПодготовки { get; set; }
public System.String ТипГОСа { get; set; }
public System.Int32 КодАктивногоООП { get; set; }
public System.String ЗЕТвНеделю { get; set; }
public System.String Точность { get; set; }
public System.Boolean ДвИГА { get; set; }
public System.Boolean ГвИГА { get; set; }
public System.Int32 СеместровНаКурсе { get; set; }
public System.Int32 ЧасовВКредите { get; set; }
public System.Int32 Индивидуальный { get; set; }
public System.String ФИО { get; set; }
public System.Boolean Военные { get; set; }
public System.Int32 КодУровняОбразования { get; set; }
public System.Int32 КодТипаПлана { get; set; }
public System.Int32 СтатусВНагрузке { get; set; }
}
}