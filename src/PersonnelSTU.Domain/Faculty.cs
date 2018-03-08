using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Common.Domain;

namespace PersonnelSTU.Domain
{
    /// <summary>
    /// VwFaculty -запрос, факультеты
    /// </summary>
    [Table("VwFaculty")]
    public class Faculty : EntityBase
    {
        /// <summary>
        /// iDepartment - код(к)
        /// </summary>
        [Column("iDepartment"), Key, Required]
        public virtual short Id { get; set; }

        /// <summary>
        /// DepName - наименование
        /// </summary>
        [Column("DepName"), Required]
        public virtual string Name { get; set; }
    }
}