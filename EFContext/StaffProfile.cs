using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_MVC_General.EFContext
{
    public class StaffProfile
    {   
        public string SerialNo { get; set; }
        public virtual Staff BelongTo { get; set; }
    }
}
