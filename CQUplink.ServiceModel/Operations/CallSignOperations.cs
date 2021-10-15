using CQUplink.ServiceModel.FCCTypes;

namespace CQUplink.ServiceModel.Operations
{
    public class CallsignLookupRequest
    {
        public string Format { get; set; } = "json";
        public string SearchValue { get; set; }
    }

    public class CallsignLookupResponse
    {
        public string Status { get; set; }
        public FCCLicenses Licenses { get; set; }
    }
}