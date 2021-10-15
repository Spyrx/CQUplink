using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQUplink.ServiceModel.Types
{
    public class License
    {
        public long Id { get; set; }

        public long LicenseeId { get; set; }

        public Licensee Licensee { get; set; }

        public long? FRN { get; set; }
        public string CallSign { get; set; }

        public long LicenseStatusId { get; set; }

        public LicenseStatus Status { get; set; }

        public DateTime ExpiredDate { get; set; }
        public long LicenseId { get; set; }
        public string LicenseDetailUrl { get; set; }
    }
}