using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Common.Domain;

namespace PersonnelSTU.Domain
{
    /// <summary>
    /// VwPerson - персональныe данныe по студенту
    /// </summary>
    [Table("VwPerson")]
    public class Person : EntityBase
    {
        /// <summary>
        /// iPerson - код, табельный номер(к)
        /// </summary>
        [Column("iPerson"), Required]
        public virtual int Id { get; set; }

        /// <summary>
        /// PersonName - фио вместе по последнимм данным
        /// </summary>
        [Column("PersonName"), MaxLength(42), Required]
        public virtual string Name { get; set; }

        /// <summary>
        /// BirthDate - Дата рождения
        /// </summary>
        [Column("BirthDate")]
        public virtual DateTime BirthDate { get; set; }

        /// <summary>
        /// Sex - пол, м или ж
        /// </summary>
        [Column("Sex")]
        public virtual char Sex { get; set; }
    }
}