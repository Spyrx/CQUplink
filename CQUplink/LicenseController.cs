using CQUplink.ServiceInterface;
using CQUplink.ServiceModel.Types;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQUplink
{
    [ApiController]
    public class LicenseController : ControllerBase
    {
        private readonly LicenseService _licenseService;
        public LicenseController(LicenseService licenseService)
        {
            _licenseService = licenseService;
        }

        [HttpGet]
        [Route("/v1/CallsignLookup/")]
        public IEnumerable<License> Get(string searchValue)
        {
            return _licenseService.Get(new ServiceModel.Operations.CallsignLookupRequest
            {
                SearchValue = searchValue
            });
        }
    }
}
