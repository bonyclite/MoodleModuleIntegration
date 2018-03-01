using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Common.Domain;

namespace PersonnelSTU.Domain
{
    /// <summary>
    /// VwStudentStatesTop - студенты по последнему состоянию
    /// </summary>
    [Table("VwStudentStatesTop")]
    public class StudentState : EntityBase
    {
        /// <summary>
        /// iMessage - код(к)
        /// </summary>
        [Column("iMessage"), Required] 
        public virtual int Id { get; set; }

        /// <summary>
        /// iStudent - табельный студента, ссылка на VwPerson.iPerson
        /// </summary>
        [Column("iStudent"), Required] 
        public virtual int StudentId { get; set; }

        /// <summary>
        ///  iState - код состояния, ссылка на rStuStates.iState
        /// </summary>
        [Column("iState"), Required] 
        public virtual short StuStateId { get; set; }

        /// <summary>
        /// StartDate - дата приказа который перевел в это состояние,от
        /// </summary>
        [Column("StartDate"), Required] 
        public virtual DateTime StartDate { get; set; }

        /// <summary>
        /// StopDateVac - если отпуск то дата до
        /// </summary>
        [Column("StopDateVac")] 
        public virtual DateTime? StopDateVac { get; set; }

        /// <summary>
        /// iGroup- код группы обучения, ссылка на VwGroups.iGroup
        /// </summary>
        [Column("iGroup"), Required] 
        public virtual short GroupId { get; set; }
        
        /// <summary>
        /// Ayear - курс студента
        /// </summary>
        [Column("Ayear"), Required]
        public virtual byte Ayear { get; set; }
        
        /// <summary>
        /// StuGroupName - наименование группы(по курсу студента)
        /// </summary>
        [Column("StuGroupName"), MaxLength(15)]
        public virtual string GroupName { get; set; }
        
        /// <summary>
        /// TheName - как PersonName в VwPerson
        /// </summary>
        [Column("TheName"), MaxLength(42), Required]
        public virtual string StudentName { get; set; }
        
        /// <summary>
        /// Zoo - шифр(заочный факультет)
        /// </summary>
        [Column("Zoo"), MaxLength(11)]
        public virtual string Zoo { get; set; } 
        
        /// <summary>
        /// iSpec- код специальности (к)
        /// </summary>
        [Column("iSpec"), MaxLength(5), Required]
        public virtual string SpecialtyId { get; set; }
        
        /// <summary>
        /// iFac - факультет, ссылка на VwFaculty.iDepartment
        /// </summary>
        [Column("iFac"), Required]
        public virtual short FacultyId { get; set; }
        
        /// <summary>
        /// EduForm - форма обучения (1- очная, 2 - заочная, 3 вечерняя)
        /// </summary>
        [Column("EduForm")]
        public virtual EduForm EduForm { get; set; }
    }
}

/*
VwStudentStatesTop - запрос студентов по последнему состоянию, где
 iMessage - код(к)
 iStudent - табельный студента, ссылка на VwPerson.iPerson
 iState - код состояния, ссылка на rStuStates.iState
 StartDate - дата приказа который перевел в это состояние,от
 StopDateVac - если отпуск то дата до
 iGroup- код группы обучения, ссылка на VwGroups.iGroup
 Ayear - курс студента
 StuGroupName - наименование группы(по курсу студента)
 TheName - как PersonName в VwPerson
 Zoo - шифр(заочный факультет)
 ISpec -специальность, ссылка на Spec.iSpec
 iFac - факультет, ссылка на VwFaculty.iDepartment
 EduForm - форма обучения, как и в Spec.EduForm
*/