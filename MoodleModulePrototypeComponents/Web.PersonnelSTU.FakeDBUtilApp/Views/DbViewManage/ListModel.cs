using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Web.PersonnelSTU.FakeDBUtilApp.Views.DbViewManage
{
    public class ListModel
    {
        public IList<string> SelectedViews { get; set; }
        public IList<SelectListItem> Views { get; set; }

        public ListModel()
        {
            SelectedViews = new List<string>();
            Views = new List<SelectListItem>();
        }
    }
}