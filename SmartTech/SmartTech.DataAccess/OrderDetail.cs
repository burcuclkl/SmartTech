using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SmartTech.DataAccess
{
   public class OrderDetail
    {
        [Key]

        public int Id { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }


        [ForeignKey("Order")]
        public virtual int OrderId { get; set; }

        public virtual Order Order { get; set; }


        [ForeignKey("Product")]

        public virtual int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
