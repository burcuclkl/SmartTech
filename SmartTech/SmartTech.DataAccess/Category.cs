using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SmartTech.DataAccess
{
   public class Category
    {
        [Key]

        public int Id { get; set; }


        [MaxLength(100)]
        [MinLength(3)]
        [Required]

        public string Name { get; set; }

        public string Icon { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
