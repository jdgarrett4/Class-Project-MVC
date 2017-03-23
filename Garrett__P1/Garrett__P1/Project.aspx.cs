using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Garrett__P1
{
    public partial class Project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void butCalculate_Click(object sender, EventArgs e)
        {
            //step One
            decimal numberOfRafters;
            int numberOfBoats;
            string tourLocation;
            decimal baseTourRate = 0M;
            decimal totalBaseTourFee;
            bool guideNeed;
            decimal guideFee;
            decimal totalGuideFee;
            string dayWeek;
            decimal weekendSurcharge = 0M;
            decimal totalWeekendSurcharge;
            decimal subtotal;
            decimal salesTaxRate;
            decimal salesTaxCharge;
            decimal total;


            //step Two gathering values
            numberOfRafters = Convert.ToInt32(txtNumberOfRafters.Text);
            tourLocation = Convert.ToString(ddlRiverTour.SelectedValue);
            numberOfBoats = Convert.ToInt32(txtNumberOfRafters.Text);
           // baseTourRate = Convert.ToDecimal(ddlRiverTour.SelectedValue);
            dayWeek = Convert.ToString(rblWeek.SelectedValue);
            guideFee = Convert.ToDecimal(chkGuided.Checked);
            guideNeed = chkGuided.Checked;
            //weekendSurcharge = Convert.ToDecimal(rblWeek.SelectedValue);
            salesTaxRate = .07M;
            Trace.Warn("numberOfRafters =" + numberOfRafters);

            //if statements

            //Number of boats
            if (numberOfRafters < 9)
            {
                numberOfBoats = 1;
            }
            else if (numberOfRafters < 17)
            {
                numberOfBoats = 2;
            }

            else if (numberOfRafters < 25)
            {
                numberOfBoats = 3;
            }

            else if (numberOfRafters < 33)
            {
                numberOfBoats = 4;
            }

          
            Trace.Warn("numberofBoats = " + numberOfBoats);

            //basetour rate

            if (tourLocation == "F")
            {
                baseTourRate = 40M;
            }
            else if (tourLocation == "N")
            {
                baseTourRate = 30M;
            }

            else if (tourLocation == "T")
            {
                baseTourRate = 20M;
            }

            Trace.Warn("tourLocation =" + tourLocation);
            Trace.Warn("baseTourRate = " + baseTourRate);

            //guide fee
            if (guideNeed == true)
            {
                guideFee = 35M;
            }
            else if (guideNeed == false)
            {
                guideFee = 0M;
            }
            Trace.Warn("guideNeed =" + guideNeed);
            Trace.Warn("guideFee =" + guideFee);

            //day of the week
            if (dayWeek == "WkE")
            {
                weekendSurcharge = 10M;
            }
            else if (dayWeek == "WkD")
            {
                weekendSurcharge = 0M;
            }
            Trace.Warn("dayWeek =" + dayWeek);
            Trace.Warn("weekendSurcharge =" + weekendSurcharge);


            //calculations

            totalBaseTourFee = numberOfRafters * baseTourRate;

            totalGuideFee = numberOfBoats * guideFee;

            totalWeekendSurcharge = numberOfRafters * weekendSurcharge;

            subtotal = totalBaseTourFee + totalGuideFee + totalWeekendSurcharge;

            salesTaxCharge = subtotal * salesTaxRate;

            total = subtotal + salesTaxCharge;

            //step four

            lblNumberOfRafts.Text = numberOfBoats.ToString();

            lblTotalBaseFee.Text = totalBaseTourFee.ToString("C");

            lblTotalGuideFee.Text = totalGuideFee.ToString("C");

            lblTotalWeekend.Text = totalWeekendSurcharge.ToString("C");

            lblSubtotal.Text = subtotal.ToString("C");

            lblSalesTaxCharge.Text = salesTaxCharge.ToString("C");

            lblTotalCharge.Text = total.ToString("C");






        }

        protected void butClear_Click(object sender, EventArgs e)
        {
            //clear text boxs and labels

            txtNumberOfRafters.Text = "";
            lblNumberOfRafts.Text = "";
            lblSalesTaxCharge.Text = "";
            lblSubtotal.Text = "";
            lblTotalBaseFee.Text = "";
            lblTotalCharge.Text = "";
            lblTotalGuideFee.Text = "";
            lblTotalWeekend.Text = "";

            chkGuided.Checked = false;
            ddlRiverTour.SelectedIndex = -1;
            rblWeek.SelectedIndex = -1;
        }
    }
}