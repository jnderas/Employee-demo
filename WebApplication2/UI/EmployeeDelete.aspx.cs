using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.UI
{
    public partial class EmployeeDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt16(Request.QueryString["id"]);
                DataTable dt = new Data.EmployeeData().Select("", "", id);
                DataRow row = dt.Rows[0];
                this.hidId.Value = row["EmployeeId"].ToString();

                this.lblFirstName.Text = row["EmployeeFirstName"].ToString();
                this.lblLastName.Text = row["EmployeeLastName"].ToString();
                this.lblPhone.Text = row["EmployeePhone"].ToString();
                this.lblZip.Text = row["EmployeeZip"].ToString();
                this.lblHireDate.Text = row["EmployeeHireDate"].ToString();
            }

        }



        

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"~/ui/Employees");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(this.hidId.Value);
            new Data.EmployeeData().Delete(id);
            Response.Redirect(@"~/ui/Employees");
        }
    }
}