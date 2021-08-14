using ServiceStack.DataAnnotations;

namespace CQUplink.ServiceModel.Types
{
    enum LicenseStatusEnum
    {
        Active = 1,
        Canceled = 2,
        Expired = 3,
        Terminated = 4,
        TerminationPending = 5
    }

    public class LicenseStatus
    {
        [PrimaryKey] public byte Id { get; set; }
        public string StatusName { get; set; }
    }
}