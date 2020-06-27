using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.UI
{
    public partial class EmployeeEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt16(Request.QueryString["id"]);
                DataTable dt = new Data.EmployeeData().Select("", "", id);
                DataRow row = dt.Rows[0];
                this.hidId.Value = row["EmployeeId"].ToString();

                this.txtFirstName.Text = row["EmployeeFirstName"].ToString();
                this.txtLastName.Text = row["EmployeeLastName"].ToString();
                this.txtPhone.Text = row["EmployeePhone"].ToString();
                this.txtZip.Text = row["EmployeeZip"].ToString();

                var sDate = row["EmployeeHireDate"].ToString();
                var date=DateTime.ParseExact(sDate, "dd-MM-YYYY HH:mm", CultureInfo.InvariantCulture);

                
                this.calHireDate.SelectedDate = date;
            }

        }



        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (calHireDate.SelectedDate == null || calHireDate.SelectedDate == DateTime.Parse("1/1/0001 00:00:00"))
            {
                Response.Redirect(@"~/ui/EmployeeCreate?error='You must select a date'");
                return;
            }


            var item = new Model.Employee();
            item.EmployeeID = Convert.ToInt16(this.hidId.Value);
            item.EmployeeLastName = txtLastName.Text;
            item.EmployeeFirstName = txtFirstName.Text;
            item.EmployeeHireDate = calHireDate.SelectedDate;
            item.EmployeePhone = txtPhone.Text;
            item.EmployeeZip = txtZip.Text;

            new Data.EmployeeData().Edit(item);
            Response.Redirect(@"~/ui/Employees");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"~/ui/Employees");
        }
    }
}