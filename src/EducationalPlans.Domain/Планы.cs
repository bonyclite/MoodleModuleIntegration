namespace EducationalPlans.Domain
{
    public class Планы
    {
        public string id { get; set; }
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public string УчебныйГод { get; set; }
        public int КодООП { get; set; }
        public int КодФормыОбучения { get; set; }
        public int КодОрганизации { get; set; }
        public int КодФакультета { get; set; }
        public bool Сокращённое { get; set; }
        public bool Дистанционное { get; set; }
        public bool ДляИностранных { get; set; }
        public string Титул { get; set; }
        public string Квалификация { get; set; }
        public string Специализация { get; set; }
        public string ВоеннаяСпециальность { get; set; }
        public string Предназначение { get; set; }
        public int СрокОбучения { get; set; }
        public int СрокОбученияМесяцев { get; set; }
        public int ЧислоКурсов { get; set; }
        public int ЧислоСессий { get; set; }
        public int КодГрафика { get; set; }
        public int НомерФГОС { get; set; }
        public string ДатаГОСа { get; set; }
        public string ДатаВерсииПриложения { get; set; }
        public int НомерВерсииПриложения { get; set; }
        public string ИмяПриложения { get; set; }
        public int НомерПользователя { get; set; }
        public string ИмяПользователя { get; set; }
        public string ИмяФайла { get; set; }
        public string ДатаИзмФайла { get; set; }
        public string ДатаУтверСоветом { get; set; }
        public int НомПротокСовета { get; set; }
        public string Примечание { get; set; }
        public int ГодНачалаПодготовки { get; set; }
        public string ТипГОСа { get; set; }
        public int КодАктивногоООП { get; set; }
        public string ЗЕТвНеделю { get; set; }
        public string Точность { get; set; }
        public bool ДвИГА { get; set; }
        public bool ГвИГА { get; set; }
        public int СеместровНаКурсе { get; set; }
        public int ЧасовВКредите { get; set; }
        public int Индивидуальный { get; set; }
        public string ФИО { get; set; }
        public bool Военные { get; set; }
        public int КодУровняОбразования { get; set; }
        public int КодТипаПлана { get; set; }
        public int СтатусВНагрузке { get; set; }
    }
}