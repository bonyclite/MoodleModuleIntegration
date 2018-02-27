<<<<<<< Updated upstream
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Domain;

namespace PersonnelSTU.Domain
{
    public class Faculty : EntityBase
=======
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;

namespace PersonnelSTU.Domain
{
    [Table("VwFaculty")] //VwFaculty -запрос, факультеты
    public class Faculty
>>>>>>> Stashed changes
    {
        [Column("iDepartment"), Key, Required] //iDepartment - код(к)
        public short Id { get; set; }

        [Column("DepName"), MaxLength(50), Required] //DepName - наименование
        public string Name { get; set; }

        [Column("DepNick"), MaxLength(16)]
        public string Nick { get; set; }
    }
}