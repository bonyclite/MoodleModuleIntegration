using System.ComponentModel;

namespace PersonnelSTU.Domain
{
    public enum EduForm
    {
        [Description("Очная")] Internal = 1,
        [Description("Заочная")] Correspondence = 2,
        [Description("Вечерняя")] Evening = 3
    }
}