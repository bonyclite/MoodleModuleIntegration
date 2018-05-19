using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCard.Web.UI.Models.StudentCard.Front
{
    public class StudentCardFrontModel
    {
        public string DepartamentName { get; set; }
        public string ProgrammName { get; set; }
        public StudentModel StudentModel { get; set; }
    }

    public class StudentModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirhtDate { get; set; }
        public string Email { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneNumber { get; set; }
    }
}