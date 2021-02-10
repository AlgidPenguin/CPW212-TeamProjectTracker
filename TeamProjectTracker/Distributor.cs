using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectTracker
{
    public class Distributor
    {
        [Key]
        public int DistibutorID { get; set; }

        public string DistributorName { get; set; }

        public int Stock { get; set; }

        public virtual Electronic Electronic { get; set; }
    }
}
