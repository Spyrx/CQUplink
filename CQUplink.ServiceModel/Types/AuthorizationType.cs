using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQUplink.ServiceModel.Types
{
    public enum AuthorizationTypeEnum
    {
        Interm = 1,
        Combo = 2,
        Final = 3,
        ComboRevision = 4
    }

    public class AuthorizationType
    {
        [PrimaryKey] public byte Id { get; set; }
        public string AuthorizationName { get; set; }
    }
}