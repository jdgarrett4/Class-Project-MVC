using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garrett_P3.Models
{
    public class DA_StatesCategory
    {
        HttpContext currentContext = HttpContext.Current;

        public List<State> GetStates()
        {
            currentContext.Trace.Warn("GetStates Called");

            //create an instance of database
            VapeEntities db = new VapeEntities();

            //fill list colection
            List<State> states = db.States.ToList();

            var sortedList = states.OrderBy(s => s.State1)
                                    .ToList();

            return states;
        }
    }
}