using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SmartTech.EnumFields;
using System.ComponentModel.DataAnnotations.Schema;


namespace SmartTech.DataAccess
{
   public class Order
    {

        [Key]

        public int Id { get; set; }

        public string InvoiceNumber { get; set; }

        public DateTime Date { get; set; }

        public DateTime ShippedDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public OrderStatus Status { get; set; }

        public decimal ShippedPrice { get; set; }

        public string DeliveryAddress { get; set; }

        public string InvoiceAddress { get; set; }

        public string Note { get; set; }


        public bool IsActive { get; set; }

        [ForeignKey("Shipper")]
        public virtual int ShipperId { get; set; }

        public virtual Shipper Shipper { get; set; }

        public virtual List<OrderDetail> Details { get; set; }

        [ForeignKey("User")]
        public virtual int UserId { get; set; }
        public virtual UserLogin User { get; set; }

    }
}
