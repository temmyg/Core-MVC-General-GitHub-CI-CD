using System;
using System.Collections.Generic;

namespace Core_MVC_General.Models
{
    public partial class Staff
    {
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string LaunchCenterId { get; set; }

        public virtual LaunchCenter LaunchCenter { get; set; }
    }
}
