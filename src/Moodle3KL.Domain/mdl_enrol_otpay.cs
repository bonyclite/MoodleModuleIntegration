namespace Moodle3KL.Domain
{
    public class mdl_enrol_otpay
    {
        public long id { get; set; }
        public string paymentid { get; set; }
        public string externalpaymentid { get; set; }
        public long instanceid { get; set; }
        public long enrolmentid { get; set; }
        public long userid { get; set; }
        public long courseid { get; set; }
        public double? amount { get; set; }
        public string currency { get; set; }
        public string type { get; set; }
        public string paymethod { get; set; }
        public string status { get; set; }
        public long? enrolmentstartdate { get; set; }
        public long? enrolmentenddate { get; set; }
        public long createdate { get; set; }
        public long timemodified { get; set; }
        public string options { get; set; }
    }
}