<<<<<<< Updated upstream
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Domain;

namespace PersonnelSTU.Domain
{
    public class Specialty : EntityBase
=======
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonnelSTU.Domain
{
    [Table("Spec")]
    public class Specialty
>>>>>>> Stashed changes
    {
        [Column("iSpec"), MaxLength(5), Required]
        public string Id { get; set; }
        
        [Column("iFac"), Required]
        public short Faculty { get; set; }
        
        [Column("SpecName"), MaxLength(220), Required]
        public string Name { get; set; }
        
        [Column("SpecNumber")]
    }
}

//Spec - таблица специальностей, где
//iSpec- код специальности (к)
//iFac - на каком факультете,  ссылка на VwFaculty.iDepartment
//SpecName - наименование спец.
//SpecNumber - номер/шифр
//EduForm - форма обучения (1- очная, 2 - заочная, 3 вечерняя)