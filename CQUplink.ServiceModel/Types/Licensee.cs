using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQUplink.ServiceModel.Types
{
    public class Licensee
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public long AddressId { get; set; }

        public Address Address { get; set; }
    }
}