using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.UI
{
    public partial class EmployeeCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["error"] != null)
                this.hidError.Value = Request["error"];

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (calHireDate.SelectedDate == null || calHireDate.SelectedDate == DateTime.Parse("1/1/0001 00:00:00"))
            {
                Response.Redirect(@"~/ui/EmployeeCreate?error='You must select a date'");
                return;
            }

            var item = new Model.Employee();
            item.EmployeeLastName = txtLastName.Text;
            item.EmployeeFirstName = txtFirstName.Text;
            item.EmployeeHireDate = calHireDate.SelectedDate;
            item.EmployeePhone = txtPhone.Text;
            item.EmployeeZip = txtZip.Text;

            new Data.EmployeeData().Create(item);
            Response.Redirect(@"~/ui/Employees");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"~/ui/Employees");
        }
    }
}