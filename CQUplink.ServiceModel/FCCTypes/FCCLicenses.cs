using System;
using System.Collections.Generic;

namespace CQUplink.ServiceModel.FCCTypes
{
    public class FCCLicenses
    {
        public int Page { get; set; }
        public int RowsPerPage { get; set; }
        public int TotalRows { get; set; }
        public DateTime LastUpdate { get; set; }
        public List<FCCLicense> License { get; set; }
    }

    public class FCCLicensesResponse
    {
        public string Status { get; set; }
        public FCCLicenses Licenses { get; set; }
    }
}