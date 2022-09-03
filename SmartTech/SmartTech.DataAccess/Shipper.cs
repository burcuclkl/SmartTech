using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SmartTech.DataAccess
{
   public class Shipper
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public decimal CapacityPrice { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }


        public virtual List<Order> Orders { get; set; }
    }
}
