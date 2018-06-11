using System;

namespace Moodle3KL.Domain
{
    public class mdl_makeup_academicdebt : mdl_entity_base
    {
        public long gradeitemid { get; set; }
        public long studentid { get; set; }
        public DateTime? date { get; set; }
        public bool isnew { get; set; }
        public bool isteacherapproved { get; set; }
        public bool isdepartamentapproved { get; set; }
    }
}