using System;
using System.Collections.Generic;
using CQUplink.ServiceModel.Operations;
using System.Linq;
using CQUplink.ServiceModel.FCCTypes;
using CQUplink.ServiceModel.Types;
using ServiceStack;

namespace CQUplink.ServiceInterface
{
    public class LicenseService : Service
    {
        public List<License> Get(CallsignLookupRequest request)
        {
            var client = new JsonServiceClient(
                $"http://data.fcc.gov/api/license-view/basicSearch/");
            var response = client.Get<CallsignLookupResponse>($"/getLicenses?searchValue={request.SearchValue}" +
                                                              $"&format=json");

            return new List<License>(response.Licenses.License.Select(q => q.ToType()));
        }
    }
}