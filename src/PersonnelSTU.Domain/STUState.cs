using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Common.Domain;

namespace PersonnelSTU.Domain
{
    /// <summary>
    /// rStuStates - таблица справочник статусов обучения студента
    /// </summary>
    [Table("rStuStates")]
    public class StuState : EntityBase
    {
        /// <summary>
        /// iState - код статуса(к)
        /// </summary>
        [Column("iState"), Required] 
        public virtual short Id { get; set; }

        /// <summary>
        /// StateName - наименование состояния
        /// </summary>
        [Column("StateName"), MaxLength(50), Required]
        public virtual string StateName { get; set; }

        /// <summary>
        /// ActionName - действие приказ для перевода в состояние
        /// </summary>
        [Column("ActionName"), MaxLength(100), Required]
        public virtual string ActionName { get; set; }

        /// <summary>
        /// StateNick- сокращенное наименование состояния(учится, отчислен,...)
        /// </summary>
        [Column("StateNick"), MaxLength(15), Required]
        public virtual string StateNick { get; set; }
    }
}

/*
 StateNick- сокращенное наименование состояния(учится, отчислен,...)
справка по состояниям-
 имеются укрупненные цифровые коды состояний-1-учится,2-в академе,3,5 -отчислен, 4 - окончил с дипломом
 получить укрупненный код = int(rStuStates.iState/1000)
 */