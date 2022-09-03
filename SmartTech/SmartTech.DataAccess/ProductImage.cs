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
   public class ProductImage
    {

        [Key]
        public int Id { get; set; }

        public string FileName { get; set; }

        public string FolderName { get; set; }

        public string Path { get; set; }

        public int Size { get; set; }

        public ImageType Type { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }


        [ForeignKey("Product")]
        public virtual int ProductId { get; set; }
        public virtual Product Product { get; set; }

       
    }
}
