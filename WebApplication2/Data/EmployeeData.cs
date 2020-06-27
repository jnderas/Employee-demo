using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication2.Model;

namespace WebApplication2.Data
{
    public class EmployeeData
    {
        public DataTable Select(string lastName="", string phone="", int id=0)
        {
            string query = @"
select [EmployeeID]
      ,[EmployeeLastName]
      ,[EmployeeFirstName]
      ,[EmployeePhone]
      ,[EmployeeZip]
      ,convert(VARCHAR, [EmployeeHireDate] ,101)EmployeeHireDate
from Employee 
where (@lastName='' or EmployeeLastName like '%'+@lastName+'%')
and (@phone='' or EmployeePhone like '%'+@phone+'%')
and (@id=0 or EmployeeId=@id)
order by EmployeeHireDate";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.Add(new SqlParameter("@lastName", lastName));
            command.Parameters.Add(new SqlParameter("@phone", phone));
            command.Parameters.Add(new SqlParameter("@id", id));
            return new Sql().query(command);

        }

        /// <summary>
        /// Returns "ok" if the operation is success, otherwise returns the error message
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public string Create(Employee item)
        {
            try
            {
                string query = @"
INSERT INTO Employee
           (EmployeeLastName
           ,EmployeeFirstName
           ,EmployeePhone
           ,EmployeeZip
           ,EmployeeHireDate)
select @EmployeeLastName
    ,@EmployeeFirstName
    ,@EmployeePhone
    ,@EmployeeZip
    ,@EmployeeHireDate";

                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@EmployeeLastName", item.EmployeeLastName);
                cmd.Parameters.AddWithValue("@EmployeeFirstName", item.EmployeeFirstName);
                cmd.Parameters.AddWithValue("@EmployeePhone", item.EmployeePhone);
                cmd.Parameters.AddWithValue("@EmployeeZip", item.EmployeeZip);
                cmd.Parameters.AddWithValue("@EmployeeHireDate", item.EmployeeHireDate);

                new Sql().nonQuery(cmd);

                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// Returns "ok" if the operation is success, otherwise returns the error message
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public string Edit (Employee item)
        {

            var sql = @"
UPDATE [dbo].[Employee]
   SET [EmployeeLastName] = @lastName
      ,[EmployeeFirstName] = @firstName
      ,[EmployeePhone] = @phone
      ,[EmployeeZip] = @zip
      ,[EmployeeHireDate] = @hireDate
 WHERE EmployeeID=@id";

            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@lastName", item.EmployeeLastName);
            cmd.Parameters.AddWithValue("@firstName", item.EmployeeFirstName);
            cmd.Parameters.AddWithValue("@phone", item.EmployeePhone);
            cmd.Parameters.AddWithValue("@zip", item.EmployeeZip);
            cmd.Parameters.AddWithValue("@hireDate", item.EmployeeHireDate);
            cmd.Parameters.AddWithValue("@id", item.EmployeeID);

            new Sql().nonQuery(cmd);

            return "ok";
        }

        /// <summary>
        /// Returns "ok" if the operation is success, otherwise returns the error message
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Delete(int id)
        {
            var sql = "delete from employee where employeeId=@id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@id", id);
            new Sql().nonQuery(cmd);
            return "ok";
        }
    }
}