using CQUplink.ServiceModel.FCCTypes;
using ServiceStack;

namespace CQUplink.ServiceModel.Operations
{
    [Route("/v1/CallsignLookup/{searchValue}", "GET")]
    public class CallsignLookupRequest : IReturn<CallsignLookupResponse>
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