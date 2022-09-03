using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartTech.DataAccess;
using SmartTech.EnumFields;
using System.Linq;
using System.Data.Entity.Core.Common.CommandTrees;

namespace SmartTech.Test
{
    [TestClass]
    public class FakeData
    {
        SmartTechEntities db = new SmartTechEntities();

       [TestMethod]
       public void CreateBrands()
        {
            string[] brands = { "ASUS", "Apple", "Samsung", "Huawei", "Arçelik", "Faber Castell", "Prada", "Oppo", "Monster", "Barilla" };

            for (int i = 0; i < 10; i++)
            {
                Brand brand = new Brand();
                brand.CreatedDate = DateTime.Now;
                brand.IsActive = true;
                brand.Name = brands[i];
                brand.OriginalName = brands[i] + "A.Ş. LTD ŞTİ.";
                db.Brand.Add(brand);
                db.SaveChanges();
            }

        }


        [TestMethod]
        public void CreateCategory()
        {
            string[] categories = { "Home Audio & Theater", "TV & Video", "Computers & Tablets", "Monitors", "Home Appliances", "Office Supplies", "Camera, Photo & Video", "Cell Phones & Accessories", "Headphones", "Video Games", "Bluetooth & Wireless Speakers" };


            for (int i = 0; i < categories.Length; i++)
            {
                Category category = new Category();
                category.CreatedDate = DateTime.Now;
                category.IsActive = true;
                category.Name = categories[i];
                db.Category.Add(category);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void  CreateShippers()
        {
            string[] shippers = { "Yurtiçi Kargo", "MNG Kargo", "Aras Kargo", "Kardeşler Kargo" };

            Random rnd = new Random();
            for (int i = 0; i < shippers.Length; i++)
            {
                Shipper shipper = new Shipper();
                shipper.CapacityPrice = rnd.Next(3, 11);
                shipper.CreatedDate = DateTime.Now;
                shipper.IsActive = true;
                shipper.Name = shippers[i];
                shipper.Phone = "0232 456 56 56";
                db.Shipper.Add(shipper);
                db.SaveChanges();

            }
        }


        [TestMethod]
        public void CreateSuppliers()
        {
            for (int i = 0; i < 50; i++)
            {
                Supplier supplier = new Supplier();
                supplier.Address = "İzmir/Türkiye";
                supplier.CompanyName = "Supplier" + (i + 1);
                supplier.CreatedDate = DateTime.Now;
                supplier.IsActive = true;
                supplier.Phone = "0232 232 32 32";
                db.Supplier.Add(supplier);
                db.SaveChanges();

            }

        }


        [TestMethod]
        public void CreateProducts()
        {
            List<Brand> allBrands = db.Brand.ToList();
            List<Supplier> allSuppliers = db.Supplier.ToList();

            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                decimal buyPrice = rnd.Next(10, 1000001);
                decimal taxRate = rnd.Next(0, 19);
                decimal rate = 100;
                decimal price = buyPrice + (buyPrice * taxRate / rate);
                decimal winRate = rnd.Next(10, 101);
                decimal winPrice = price + (price * winRate / rate);
                decimal discountRate = rnd.Next(0,(int)winRate + 1);
                decimal discountPrice = price * discountRate / rate;
                decimal salesPrice = winPrice - discountPrice;


                Product product = new Product();
                product.BuyPrice = buyPrice;
                product.TaxRate = taxRate;
                product.Price = winPrice;
                product.Discount = discountRate;
                product.SalesPrice = salesPrice;
                product.Capacity = rnd.Next(1, 101);
                product.IsActive = true;
                product.CreatedDate = DateTime.Now;
                product.Rate = rnd.Next(1, 6);
                product.RateCount = rnd.Next(1, 101);
                product.ShortName = "Product" + (i + 1);
                product.Stock = rnd.Next(1, 1001);
                product.IsNew = Convert.ToBoolean(rnd.Next(0, 2));
                product.Brand = allBrands[rnd.Next(0,10)];
                product.Supplier = allSuppliers[rnd.Next(0, 50)];
                product.LongName = product.Brand.Name + " " + product.ShortName + " " + product.Supplier.CompanyName;
                db.Product.Add(product);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void CreateProductProperties()
        {
            List<Product> allProducts = db.Product.ToList();

            Random rnd = new Random();
            foreach (Product product in allProducts)
            {
                int propCount = rnd.Next(1, 10);
                for (int i = 0; i < propCount; i++)
                {
                    ProductProperty productProperty = new ProductProperty();
                    productProperty.Product = product;
                    productProperty.Key = "Key - " + (i + 1);
                    productProperty.Value = "Value - " + (i + 1);
                    productProperty.IsActive = true;
                    productProperty.CreatedDate = DateTime.Now;
                    db.ProductProperty.Add(productProperty);
                    db.SaveChanges();
                }
            }
        }


        [TestMethod]
        public void CreateProductPictures()
        {
            List<Product> allProducts = db.Product.ToList();
            Random rnd = new Random();

            foreach (Product product in allProducts)
            {
                int imageCount = rnd.Next(5, 11);
                string name = "item-img-1-";
                List<int> imageNames = new List<int>();
                for (int i = 0; i < imageCount; i++)
                {
                    int imageName = rnd.Next(1, 16);
                    if (imageNames.Contains(imageName)==true)
                    {
                        i--;
                        continue;
                    }
                    imageNames.Add(imageName);
                    ProductImage productImage = new ProductImage();
                    productImage.Product = product;
                    productImage.CreatedDate = DateTime.Now;
                    productImage.FileName = name + imageName + ".jpg";
                    productImage.FolderName = "ProductImages";
                    productImage.IsActive = true;
                    productImage.Path = "/" + productImage.FolderName + "/" + productImage.FileName;
                    productImage.Size = rnd.Next(100, 5000);
                    productImage.Type = ImageType.JPG;
                    db.ProductImage.Add(productImage);
                    db.SaveChanges();
                }

            }
        }




        [TestMethod]
        public void CreateCategoryProducts()
        {
            List<Category> allCategories = db.Category.ToList();
            List<Product> allProducts = db.Product.ToList();

            int index = 0;
            int catIndex = 0;

            foreach (Product product in allProducts)
            {
                Category category = allCategories[catIndex];
                index++;
                if (index > 0 && index % 95 == 0)
                {
                    catIndex++;
                }
                product.Categories.Add(category);
                db.SaveChanges();
            }

        }
    }
}
