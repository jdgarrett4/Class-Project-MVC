using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Garrett_P3.Models;

namespace Garrett_P3
{
    public partial class ProductsInCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Trace.Warn("Page_Load method executed");
            //fill ddl
            if(Page.IsPostBack == false)
            {
                Trace.Warn("Pre-Postback: DDl Filled");

                //create an instance of da class
                DA_VapeCategory categoryObject = new DA_VapeCategory();

                //declare a list collection
                List<Category> returnedProducts = categoryObject.GetCategories();

                //display categories
                ddlCategories.DataSource = returnedProducts;
                ddlCategories.DataTextField = "Category1";
                ddlCategories.DataValueField = "CategoryID";
                ddlCategories.DataBind();

                ListItem itemToAdd = new ListItem("Please choose a product", "");
                ddlCategories.Items.Insert(0, itemToAdd);
            }
        }

        protected void ddlCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategoryID = ddlCategories.SelectedValue;
            Trace.Warn("selectedCAtegoryID = " + selectedCategoryID);

            //create an instance of da class

            DA_VapeInventory productsDAObject = new DA_VapeInventory();

            //declare list collection
            List<product> products = productsDAObject.GetProductsbyCategory(selectedCategoryID);

            //bind gridview
            gvProducts.DataSource = products;
            gvProducts.DataBind();

        }
    }
}