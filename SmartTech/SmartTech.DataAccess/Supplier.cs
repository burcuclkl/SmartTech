﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SmartTech.DataAccess
{
   public class Supplier
    {
        [Key]
        public int Id { get; set; }


        public string CompanyName { get; set; }
        
        public string Phone { get; set; }

        public string Address{ get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
