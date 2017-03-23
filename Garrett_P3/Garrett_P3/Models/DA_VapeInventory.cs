using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garrett_P3.Models
{
    public class DA_VapeInventory
    {
        HttpContext currentContext = HttpContext.Current;

        public List<product> GetProducts()
        {
            currentContext.Trace.Warn("GetProducts method called!");

            //create an instance of database
            VapeEntities db = new VapeEntities();

            //fill list collection
            List<product> products = db.products.ToList();

            var sortedList = products.OrderBy(s => s.Product_Name)
                                        .ToList();

            return sortedList;
        }
        public List<product> GetProductsbyCategory(string parCategoryID)
        {
            currentContext.Trace.Warn("GetProducts method called!");
            currentContext.Trace.Warn("parCategoryID =" + parCategoryID);

            //create an instance of database
            VapeEntities db = new VapeEntities();

            //fill list collection
            List<product> products = db.products.ToList();

            var sortedList = products.Where(s => s.CategoryID == parCategoryID)
                                        .OrderBy(s => s.Product_Name)
                                        .ToList();

            return sortedList;
        }
        public List<product> GetSelectedProduct(int parSKU)
        {
            currentContext.Trace.Warn("GetSelectedProducts method called!");
            currentContext.Trace.Warn("parSKU =" + parSKU);
            //create an instance of database
            VapeEntities db = new VapeEntities();

            //fill list collection
            List<product> products = db.products.ToList();

            var sortedList = products.Where(s => s.SKU == parSKU)
                                        .ToList();

            return sortedList;
        }
    }
}