using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TeacherCard.Web.UI.Models.Student.ListWithAcademicDebts
{
    public class StudentListWithAcademicDebtsModel
    {
        public long ProgrammItemId { get; set; }
        public string DisciplineName { get; set; }

        public IEnumerable<long> StudentIds { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Выберите дату пересдачи")]
        public DateTime MakeUpAcademicDebtsDate { get; set; }

        public List<StundetModel> Students { get; set; }

        public StudentListWithAcademicDebtsModel()
        {
            Students = new List<StundetModel>();
        }
    }

    public class StundetModel
    {
        public long MdlUser { get; set; }
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public long GroupId { get; set; }
        public string GroupName { get; set; }

        public string FullName => $"{LastName} {FirstName} {MiddleName}";
    }
}