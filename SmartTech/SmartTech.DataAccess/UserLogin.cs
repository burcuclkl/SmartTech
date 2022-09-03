using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SmartTech.EnumFields;

namespace SmartTech.DataAccess
{
   public class UserLogin
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }

        public string Question  { get; set; }

        public string Answer { get; set; }

        public string Phone { get; set; }

        public Gender Gender { get; set; }

        public string LastLoginIp { get; set; }

        public DateTime LastLoginDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsConfirmed { get; set; }

        public bool IsActive { get; set; }

        public virtual List<Order> Orders { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}
