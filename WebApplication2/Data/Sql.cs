using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication2.Data
{
    public class Sql
    {
        /// <summary>
        /// Returns a DataTable with the results of a query
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public  DataTable query(SqlCommand command)
        {
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            conn.Open();
            command.Connection = conn;
            
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            conn.Close();

            return dt;
        }


        /// <summary>
        /// Return the number of rows affected after execute a query
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public  int  nonQuery(SqlCommand command)
        {
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            conn.Open();
            command.Connection = conn;          
            int r = command.ExecuteNonQuery();            
            conn.Close();

            return r;
        }
    }
}