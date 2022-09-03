using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartTech.DataAccess
{
   public class Product
    {
        [Key]

        public int Id { get; set; }

        public string ShortName { get; set; }

        public string LongName { get; set; }

        public int RateCount { get; set; }

        public decimal Rate { get; set; }

        public bool IsNew { get; set; }

        public decimal BuyPrice { get; set; }

        public decimal TaxRate { get; set; }

        public decimal Price { get; set; }

        public decimal SalesPrice { get; set; }

        public decimal Discount { get; set; }

        public int Stock { get; set; }

        public decimal Capacity { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }




        [ForeignKey("Brand")]

        public virtual int BrandId { get; set; }

        public virtual Brand Brand { get; set; }


        [ForeignKey("Supplier")]
        public virtual int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; }


        public virtual List<OrderDetail> OrderDetails { get; set; }

        public virtual List<Category> Categories { get; set; }

        public virtual List<Comment> Comments { get; set; }

        public virtual List<ProductImage> Images { get; set; }

        public virtual List<ProductProperty> Properties { get; set; }
    }
}
