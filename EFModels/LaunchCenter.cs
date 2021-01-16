using System;
using System.Collections.Generic;

namespace Core_MVC_General.Models
{
    public partial class LaunchCenter
    {
        public LaunchCenter()
        {
            Staff = new HashSet<Staff>();
        }

        public string Id { get; set; }
        public string Commander { get; set; }
        public string LaunchModel { get; set; }

        public virtual ICollection<Staff> Staff { get; set; }
    }
}
