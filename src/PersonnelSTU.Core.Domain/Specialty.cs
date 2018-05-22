using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonnelSTU.Core.Domain
{
    /// <summary>
    /// Spec - таблица специальностей
    /// </summary>
    [Table("Spec")]
    public class Specialty : EntityBase
    {
        /// <summary>
        /// iSpec- код специальности (к)
        /// </summary>
        [Column("iSpec"), MaxLength(5), Required]
        public virtual string Id { get; set; }

        /// <summary>
        /// iFac - на каком факультете, ссылка на VwFaculty.iDepartment
        /// </summary>
        [Column("iFac"), Required]
        public virtual short Faculty { get; set; }

        /// <summary>
        /// SpecName - наименование спец.
        /// </summary>
        [Column("SpecName"), MaxLength(220), Required]
        public virtual string Name { get; set; }

        /// <summary>
        /// SpecNumber - номер/шифр
        /// </summary>
        [Column("SpecNumber"), MaxLength(8), Required]
        public virtual string SpecNumber { get; set; }

        /// <summary>
        /// форма обучения (1- очная, 2 - заочная, 3 вечерняя)
        /// </summary>
        [Column("EduForm")]
        public virtual short EduForm { get; set; }
    }
}