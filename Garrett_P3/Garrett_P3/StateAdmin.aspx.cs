using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Garrett_P3.Models;

namespace Garrett_P3
{
    public partial class StateAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Trace.Warn("Pre_Load method called");

            //fill ddl
            if (Page.IsPostBack == false)
            {
                Trace.Warn("Pre-Postback: ddl filled");
                //create instance of da class
                DA_StatesCategory stateObject = new DA_StatesCategory();

                //declare list collection
                List<State> returnedStates = stateObject.GetStates();

                //display categories
                ddlStates.DataSource = returnedStates;
                ddlStates.DataTextField = "State1";
                ddlStates.DataValueField = "StateID";
                ddlStates.DataBind();
            }
        }

        protected void ddlStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStateID = ddlStates.SelectedValue;
            Trace.Warn("selectedStateID =" + selectedStateID);

            //create an instance of da class
            DA_Customers customerDAObject = new DA_Customers();

            //declare list collection
            List<Customer> customers = customerDAObject.GetSelectedCustomer(selectedStateID);

            dataListStates.DataSource = customers;
            dataListStates.DataBind();
        }
    }
}