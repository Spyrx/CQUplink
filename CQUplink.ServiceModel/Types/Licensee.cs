using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQUplink.ServiceModel.Types
{
    public class Licensee
    {
        [AutoIncrement] public long Id { get; set; }
        public string Name { get; set; }

        [References(typeof(Address))] public long AddressId { get; set; }

        [Reference] public Address Address { get; set; }
    }
}