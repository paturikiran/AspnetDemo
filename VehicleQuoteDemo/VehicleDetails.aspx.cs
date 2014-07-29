using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VehicleQuoteDemo.Lookup;

namespace VehicleQuoteDemo
{
    public partial class VehicleDetails : System.Web.UI.Page
    {
        private Lookup.Lookup lookup;

        public String Year { get { return ddlYear.SelectedItem.Value; } }

        public VehicleDetails()
        {
            lookup = new Lookup.Lookup();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindYearsList();
            }
        }

        protected void ddlYear_Change(object sender, EventArgs e)
        {
            BindMakesList(Year);
        }
        private void BindYearsList()
        {
            var yearsList = lookup.GetListOfYears();
            ddlYear.DataSource = yearsList;
            ddlYear.DataBind();
        }

        private void BindMakesList(string year)
        {
            var makesList = lookup.GetVehicleMakesList(year);
            ddlMake.DataSource = makesList;
            ddlMake.DataTextField = "Make";
            ddlMake.DataValueField = "Make";
            ddlMake.DataBind();
        }

        protected void Proceed(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Year = Year;
            vehicle.Make = ddlMake.SelectedItem.Value;
            QuoteInformation quoteInformation = Session["quoteDetails"] as QuoteInformation;
            quoteInformation.VehicleInformation = vehicle;
            Session["quoteDetails"] = quoteInformation;
            Response.Redirect("Quote.aspx");
        }
    }
}