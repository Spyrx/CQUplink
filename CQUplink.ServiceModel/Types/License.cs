using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQUplink.ServiceModel.Types
{
    public class License
    {
        [AutoIncrement] public long Id { get; set; }

        [References(typeof(Licensee))] public long LicenseeId { get; set; }

        [Reference] public Licensee Licensee { get; set; }

        public long? FRN { get; set; }
        public string CallSign { get; set; }

        [References(typeof(LicenseStatus))] public long LicenseStatusId { get; set; }

        [Reference] public LicenseStatus Status { get; set; }

        public DateTime ExpiredDate { get; set; }
        public long LicenseId { get; set; }
        public string LicenseDetailUrl { get; set; }
    }
}