namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_programmitems
    {
        public long id { get; set; }
        public long? programmid { get; set; }
        public long? agenum { get; set; }
        public long? courseclsid { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public long? mdlcourse { get; set; }
        public string type { get; set; }
        public string required { get; set; }
        public int? maxcredit { get; set; }
        public long? maxduration { get; set; }
        public long? hours { get; set; }
        public long? hourstheory { get; set; }
        public long? hourspractice { get; set; }
        public short? eduweeks { get; set; }
        public long? instrlevelid { get; set; }
        public string gradelevel { get; set; }
        public string scale { get; set; }
        public string mingrade { get; set; }
        public string sname { get; set; }
        public string scode { get; set; }
        public string status { get; set; }
        public long? departmentid { get; set; }
        public string about { get; set; }
        public string notice { get; set; }
        public long? controltypeid { get; set; }
        public long? hoursweek { get; set; }
        public string explanatory { get; set; }
        public short? gradesyncenabled { get; set; }
        public short? incjournwithoutgrade { get; set; }
        public short? incjournwithunsatisfgrade { get; set; }
        public long? altgradeitem { get; set; }
        public string metasyncon { get; set; }
        public long? metaprogrammitemid { get; set; }
        public string billingtext { get; set; }
        public string billingrules { get; set; }
        public double salfactor { get; set; }
        public long? hourslab { get; set; }
        public long? hoursind { get; set; }
        public long? hourscontrol { get; set; }
        public short autohours { get; set; }
        public long? hoursclassroom { get; set; }
    }
}