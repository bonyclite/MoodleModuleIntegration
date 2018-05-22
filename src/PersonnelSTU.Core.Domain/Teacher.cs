using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonnelSTU.Core.Domain
{
    /// <summary>
    /// PpsSite - Преподаватели
    /// </summary>
    [Table("PpsSite")]
    public class Teacher : EntityBase
    {
        /// <summary>
        /// IDD - код на текущий момент(к) изменяется после обновления
        /// </summary>
        [Column("IDD"), Required]
        public virtual int Id { get; set; }

        /// <summary>
        /// TabNo - табельный работника, как в кадрах
        /// </summary>
        [Column("TabNo"), Required]
        public virtual int TabelNumber { get; set; }

        /// <summary>
        /// Fio - фио полностью
        /// </summary>
        [Column("Fio"), MaxLength(70)]
        public virtual string Fio { get; set; }

        /// <summary>
        /// DepName - кафедра
        /// </summary>
        [Column("DepName"), MaxLength(250), Required]
        public virtual string Department { get; set; }

        /// <summary>
        /// PostName - должность
        /// </summary>
        [Column("PostName"), MaxLength(250), Required]
        public virtual string PostName { get; set; }

        /// <summary>
        /// us - степень
        /// </summary>
        [Column("us"), MaxLength(70)]
        public virtual string Degree { get; set; }

        /// <summary>
        /// uz - звание
        /// </summary>
        [Column("uz"), MaxLength(70)]
        public virtual string Rank { get; set; }
    }
}

/*
 PpsSite- таблица, где
 IDD - код на текущий момент(к) изменяется после обновления
 TabNo - табельный работника, как в кадрах
 Fio - фио полностью
 sht - ш-штат, с - совместитель
 DepName - кафедра
 PostName - должность
 us,uz степень,звание
*/