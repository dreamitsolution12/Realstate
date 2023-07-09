using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace RealEstate.DataBase
{
    public class DbLayer
    {
        SqlConnection con = new SqlConnection("Data Source=208.91.198.174;Initial Catalog=realstate1db;User Id=realstate1db;Password=Pradeep@123");
        public DataTable ExecProcPara_dt(string Procedure, SqlParameter[] sp)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(Procedure, con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter p in sp) 
                {
                    cmd.Parameters.Add(p);
                }
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                cmd.Parameters.Clear();
            }
            catch (Exception exc)
            {
                throw exc;
            }
            return dt;
        }

        public DataTable ExecuteQuery_dt(string Query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception exc)
            {
                throw exc;
            }
            return dt;
        }

        public DataTable ExecProcPara_ds(string Procedure, SqlParameter[] sp)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(Procedure, con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter p in sp)
                {
                    cmd.Parameters.Add(p);
                }
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                cmd.Parameters.Clear();
            }
            catch (Exception exc)
            {
                throw exc;
            }
            return dt;
        }

        public DataTable ExecuteQuery_ds(string Query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception exc)
            {
                throw exc;
            }
            return dt;
        }

    }
}