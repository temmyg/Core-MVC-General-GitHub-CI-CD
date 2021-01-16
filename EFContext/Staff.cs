using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core_MVC_General.EFContext
{
    public class Staff
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StaffID { get; set; }
        public string Name { get; set; }

        public string LaunchCenterID { get; set; }

        public virtual LaunchCenter WorkForCenter { get; set; }

        public virtual StaffProfile StaffProfile { get; set; }
    }
}
