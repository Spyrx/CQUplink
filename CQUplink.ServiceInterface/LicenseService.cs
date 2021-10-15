using System;
using System.Collections.Generic;
using CQUplink.ServiceModel.Operations;
using System.Linq;
using CQUplink.ServiceModel.FCCTypes;
using CQUplink.ServiceModel.Types;
using System.Net.Http;
using Newtonsoft.Json;
using RestSharp;

namespace CQUplink.ServiceInterface
{
    public class LicenseService
    {
        public List<License> Get(CallsignLookupRequest request)
        {
            var client = new RestClient();
            client.BaseUrl = new Uri($"http://data.fcc.gov/api/license-view/basicSearch");

            var restRequest = new RestRequest($"getLicenses?searchValue={request.SearchValue}" + "&format=json", Method.GET);
            var fccResponse = client.Execute<FCCLicensesResponse>(restRequest).Data;

            return new List<License>(fccResponse.Licenses.License.Select(q => q.ToType()));
        }
    }
}