using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garrett_P3.Models
{
    public class DA_VapeCategory
    {
        HttpContext curretnContext = HttpContext.Current;

        public List<Category> GetCategories()
        {
            curretnContext.Trace.Warn("GetCategories method called!");

            //Create an instance of datebase
            VapeEntities db = new VapeEntities();

            //fill list collection
            List<Category> categories = db.Categories.ToList();

            var sortedList = categories.OrderBy(s => s.Category1)
                                        .ToList();

            return categories;

        }
    }
}