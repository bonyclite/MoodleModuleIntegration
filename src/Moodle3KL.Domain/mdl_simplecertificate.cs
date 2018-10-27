namespace Moodle3KL.Domain
{
    public class mdl_simplecertificate : mdl_entity_base
    {
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short? introformat { get; set; }
        public long timecreated { get; set; }
        public long? timemodified { get; set; }
        public short width { get; set; }
        public short height { get; set; }
        public string certificateimage { get; set; }
        public string certificatetext { get; set; }
        public string certificatetextformat { get; set; }
        public short certificatetextx { get; set; }
        public short certificatetexty { get; set; }
        public short certificatetextwidth { get; set; }
        public short certificatetextheight { get; set; }
        public short certificatetextborder { get; set; }
        public short alternatecode { get; set; }
        public string coursename { get; set; }
        public long outcome { get; set; }
        public long certdate { get; set; }
        public string certdatefmt { get; set; }
        public long certgrade { get; set; }
        public long gradefmt { get; set; }
        public long grademodfmt { get; set; }
        public short gradedecimals { get; set; }
        public string forcelanguage { get; set; }
        public string emailfrom { get; set; }
        public string emailothers { get; set; }
        public short emailteachers { get; set; }
        public short? reportcert { get; set; }
        public short delivery { get; set; }
        public long requiredtime { get; set; }
        public short printqrcode { get; set; }
        public short qrcodefirstpage { get; set; }
        public short codex { get; set; }
        public short codey { get; set; }
        public short enablesecondpage { get; set; }
        public short? secondpagex { get; set; }
        public short? secondpagey { get; set; }
        public string secondpagetext { get; set; }
        public string secondpagetextformat { get; set; }
        public string secondimage { get; set; }
        public string timestartdatefmt { get; set; }
    }
}