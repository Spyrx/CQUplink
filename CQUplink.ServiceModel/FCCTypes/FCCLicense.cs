using System;
using System.ComponentModel;
using CQUplink.ServiceModel.Types;
using License = CQUplink.ServiceModel.Types.License;

namespace CQUplink.ServiceModel.FCCTypes
{
    public class FCCLicense
    {
        public string LicName { get; set; }
        public string FRN { get; set; }
        public string Callsign { get; set; }
        public string CategoryDesc { get; set; }
        public string ServiceDesc { get; set; }
        public string StatusDesc { get; set; }
        public DateTime ExpiredDate { get; set; }
        public long LicenseID { get; set; }
        public string LicDetailURL { get; set; }
    }

    public static class FccLincensesExtension
    {
        public static License ToType(this FCCLicense value)
        {
            return new License()
            {
                CallSign = value.Callsign,
                FRN = !string.IsNullOrEmpty(value.FRN) ? long.Parse(value.FRN) : null,
                Status = new LicenseStatus() {StatusName = value.StatusDesc},
                ExpiredDate = value.ExpiredDate,
                Licensee = new Licensee()
                {
                    Name = value.LicName
                },
                LicenseDetailUrl = value.LicDetailURL,
                LicenseId = value.LicenseID,
            };
        }
    }
}