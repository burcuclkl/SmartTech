using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SmartTech.DataAccess
{
   public class ProductProperty
    {
        [Key]

        public int Id { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey("Product")]

        public virtual int ProductId { get; set; }
        public virtual Product Product { get; set; }

        
    }
}
