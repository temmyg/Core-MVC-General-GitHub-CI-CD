using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core_MVC_General.EFContext
{
    public class LaunchCenter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ID { get; set; }
        public string Commander { get; set; }

        public string LaunchModel { get; set; }

        public virtual ICollection<Staff> Personnel { get; set; }
    }
}
