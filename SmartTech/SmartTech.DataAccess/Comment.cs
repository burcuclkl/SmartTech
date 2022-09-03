using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace SmartTech.DataAccess
{
   public class Comment
    {

        [Key]

        public int Id { get; set; }

        public string Content { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }


        public bool IsActive { get; set; }


        [ForeignKey("User")]
        public virtual int UserId { get; set; }
        public virtual UserLogin User { get; set; }

        [ForeignKey("Product")]
        public virtual int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
