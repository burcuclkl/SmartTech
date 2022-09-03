using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SmartTech.DataAccess
{
   public class SmartTechEntities : DbContext
    {
        public SmartTechEntities()
                : base("name=SmartCS")
        {

        }


        public virtual DbSet<Brand> Brand { get; set; }

        public virtual DbSet<Category> Category { get; set; }

        public virtual DbSet<Comment> Comment { get; set; }

        public virtual DbSet<Order> Order { get; set; }

        public virtual DbSet<OrderDetail> OrderDetail { get; set; }

        public virtual DbSet<Product> Product { get; set; }

        public virtual DbSet<ProductImage> ProductImage { get; set; }

        public virtual DbSet<ProductProperty> ProductProperty { get; set; }

        public virtual DbSet<Shipper> Shipper{ get; set; }

        public virtual DbSet<Supplier> Supplier { get; set; }

        public virtual DbSet<UserLogin> UserLogin { get; set; }

    }
}
