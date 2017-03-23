using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Garrett_P3.Models;

namespace Garrett_P3
{
    public partial class SingleProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Trace.Warn("Page_Load method called");

            //fill the ddl
            if (Page.IsPostBack == false)
            {
                Trace.Warn("Pre-Postback ddl filled");

                //create an instance of a da class
                DA_VapeInventory categoryObject = new DA_VapeInventory();

                //declare list collection 
                List<product> returnedProducts = categoryObject.GetProducts();

                //display ddl

                ddlProducts.DataSource = returnedProducts;
                ddlProducts.DataTextField = "Product_Name";
                ddlProducts.DataValueField = "SKU";
                ddlProducts.DataBind();

                ListItem itemToAdd = new ListItem("Please choose a product", "");
                ddlProducts.Items.Insert(0, itemToAdd);
            }
        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedSKU = Convert.ToInt32(ddlProducts.SelectedValue);
            Trace.Warn("selectedSKU =" + selectedSKU);

            //create an instance of the da class
            DA_VapeInventory productsDAObject = new DA_VapeInventory();

            //declare a list collection
            List<product> products = productsDAObject.GetSelectedProduct(selectedSKU);

            //bind to details view
            dvProducts.DataSource = products;
            dvProducts.DataBind();
        }
    }
}