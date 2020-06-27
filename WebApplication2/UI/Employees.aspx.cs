using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Data;

namespace WebApplication2.UI
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            //load employees
            LoadEmployess();
        }

        public void LoadEmployess()
        {
            var lastName = this.txtLastName.Text;
            var phone = this.txtPhone.Text;
            this.employeesGrid.DataSource = new EmployeeData().Select(lastName, phone);
            this.employeesGrid.DataBind();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ui/EmployeeCreate");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (employeesGrid.SelectedRow == null)
            {
                Response.Redirect(@"~/ui/employees?error='You must select a record'");
                return;
            }

            var id = employeesGrid.SelectedRow.Cells[1].Text;
            Response.Redirect(@"~/ui/employeeEdit?id="+id);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (employeesGrid.SelectedRow == null)
            {
                Response.Redirect(@"~/ui/employees?error='You must select a record'");
                return;
            }

            var id = employeesGrid.SelectedRow.Cells[1].Text;
            Response.Redirect(@"~/ui/employeeDelete?id=" + id);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            this.LoadEmployess();
        }

        
    }
}