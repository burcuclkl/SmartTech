using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SmartTech.DataAccess
{
   public class Brand
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public string OriginalName { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
