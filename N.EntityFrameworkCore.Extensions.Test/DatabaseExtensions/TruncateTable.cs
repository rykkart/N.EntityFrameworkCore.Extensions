﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace N.EntityFrameworkCore.Extensions.Test.DatabaseExtensions
{
    [TestClass]
    public class TruncateTable : DatabaseExtensionsBase
    {
        [TestMethod]
        public void With_Orders_Table()
        {
            var dbContext = SetupDbContext(true);
            int oldOrdersCount = dbContext.Orders.Count();
            dbContext.Database.TruncateTable("Orders");
            int newOrdersCount = dbContext.Orders.Count();

            Assert.IsTrue(oldOrdersCount > 0, "Orders table should have data");
            Assert.IsTrue(newOrdersCount == 0, "Order table should be empty after truncating");
        }
    }
}