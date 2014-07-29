using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VehicleQuoteDemo.Lookup;
namespace VehicleQuoteDemo
{
    public partial class PersonalDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindListOfStatesToDropDownList();
            }
        }

        protected void Proceed(Object sender, EventArgs e)
        {
            Person person = new Person();
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;
            person.StateOfResidence = new State();
            person.StateOfResidence.Code = ddlStates.SelectedItem.Value;
            person.StateOfResidence.Name = ddlStates.SelectedItem.Text;
            //Sessions
            QuoteInformation quote = new QuoteInformation();
            quote.InsurerDetails = person;
            Session["quoteDetails"] = quote;
            Response.Redirect("VehicleDetails.aspx");
           
        }

        private void BindListOfStatesToDropDownList()
        {
            Lookup.Lookup lookup = new Lookup.Lookup();
            var states =   lookup.GetListOfStates();
            ddlStates.DataSource = states;
            ddlStates.DataTextField = "Name";
            ddlStates.DataValueField = "Code";
            ddlStates.DataBind();
        }
    }
}