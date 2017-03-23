using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garrett_P3.Models
{
    public class DA_Customers
    { HttpContext currentContext = HttpContext.Current;
        public List<Customer> GetSelectedCustomer(string parStateID)
        {
            currentContext.Trace.Warn("GetSelectedState method called");
            currentContext.Trace.Warn("ParStateID = " + parStateID);

            //create an instance of the ef database
            VapeEntities db = new VapeEntities();

            //fill a list collection
            List<Customer> customers = db.Customers.ToList();

            var sortedList = customers.Where(s => s.State == parStateID)
                                            .ToList();

            return sortedList;
        }
    }
}