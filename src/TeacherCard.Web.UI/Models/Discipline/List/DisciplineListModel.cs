using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeacherCard.Web.UI.Models.Discipline.List
{
    public class DisciplineListModel
    {
        public IEnumerable<DisciplineModel> Disciplines { get; set; }
    }

    public class DisciplineModel
    {
        public long MdlCourse { get; set; }
        public long ProgrammItemId { get; set; }
        public string Name { get; set; }
    }

}