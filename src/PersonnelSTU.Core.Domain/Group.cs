using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonnelSTU.Core.Domain
{
    /// <summary>
    /// VwGroups - группы студентов
    /// </summary>
    [Table("VwGroups")]
    public class Group : EntityBase
    {
        /// <summary>
        /// iGroup - код(к)
        /// </summary>
        [Column("iGroup"), Required]
        public virtual short Id { get; set; }
        
        /// <summary>
        /// gPrefix - название группы без цифр
        /// </summary>
        [Column("gPrefix"), Required]
        public virtual string Name { get; set; }
        
        /// <summary>
        /// gIndex - последние две цифры наименования группы(не зависимо от курса группы)
        /// </summary>
        [Column("gIndex"), Required]
        public virtual short Index { get; set; }
        
        /// <summary>
        /// дата поступления(формирования группы)
        /// </summary>
        [Column("StartDate"), Required]
        public virtual DateTime StartDate { get; set; }
        
        /// <summary>
        /// iSpec- код специальности (к)
        /// </summary>
        [Column("iSpec"), MaxLength(5), Required]
        public virtual string SpecialtyId { get; set; }
        
        /// <summary>
        /// iFac - код(к)
        /// </summary>
        [Column("iFac"), Key, Required]
        public virtual short FacultyId { get; set; }
    }
}