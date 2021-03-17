using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectTracker
{
    public class Inventory
    {
        [Key]
        public int StockId { get; set; }

        public int Stock { get; set; }

        public virtual ICollection<Distributor> Distributor { get; set; }

        public virtual Distributor DistributorID { get; set; }

        public virtual ICollection<Electronic> Electronic { get; set; }

        public virtual Electronic ProductId { get; set; }
    }
}
