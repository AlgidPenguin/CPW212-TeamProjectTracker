using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectTracker
{
    public class Electronic
    {
        /// <summary>
        /// The unique identification number for a specific product
        /// </summary>
        [Key]
        public int ProductId { get; set; }

        /// <summary>
        /// The entire name of the product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The name of the manufacturer where the product was made
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// The price of the product in US currency
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// The category to which the product belongs to
        /// </summary>
        public string Category { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
