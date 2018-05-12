namespace Moodle3KL.Domain
{
    public class mdl_lti_tool_proxies : mdl_entity_base
    {
        public string name { get; set; }
        public string regurl { get; set; }
        public short state { get; set; }
        public string guid { get; set; }
        public string secret { get; set; }
        public string vendorcode { get; set; }
        public string capabilityoffered { get; set; }
        public string serviceoffered { get; set; }
        public string toolproxy { get; set; }
        public long createdby { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
    }
}