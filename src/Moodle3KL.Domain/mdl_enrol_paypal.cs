namespace Moodle3KL.Domain
{
    public class mdl_enrol_paypal : mdl_entity_base {
        public string business { get; set; }
        public string receiver_email { get; set; }
        public string receiver_id { get; set; }
        public string item_name { get; set; }
        public long courseid { get; set; }
        public long userid { get; set; }
        public long instanceid { get; set; }
        public string memo { get; set; }
        public string tax { get; set; }
        public string option_name1 { get; set; }
        public string option_selection1_x { get; set; }
        public string option_name2 { get; set; }
        public string option_selection2_x { get; set; }
        public string payment_status { get; set; }
        public string pending_reason { get; set; }
        public string reason_code { get; set; }
        public string txn_id { get; set; }
        public string parent_txn_id { get; set; }
        public string payment_type { get; set; }
        public long timeupdated { get; set; }
    }
}