using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartTech.DataAccess;

namespace SmartTech.Test
{
    [TestClass]
    public class DatabaseTest
    {
        [TestMethod]
        public void CreateDatabase()
        {
            SmartTechEntities db = new SmartTechEntities();
            if (db.Database.Exists()==true)
            {
                db.Database.Delete();
            }
            db.Database.Create();
        }
    }
}
