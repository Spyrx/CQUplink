using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQUplink.ServiceModel.Types
{
    public enum OperatorClassEnum
    {
        Technician = 1,
        TechnicianPlus = 2,
        General = 3,
        AmateurExtra = 4,
        Advanced = 5,
        Novice = 6
    }

    public class OperatorClass
    {
        [PrimaryKey] public byte Id { get; set; }
        public string OperatorClassName { get; set; }
    }
}