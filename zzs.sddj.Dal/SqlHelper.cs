using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace zzs.sddj.Dal
{
    public class SqlHelper
    {
        private readonly static string connstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        public static DataTable GetTable(string sql, CommandType type, params SqlParameter[] pars)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlDataAdapter atper = new SqlDataAdapter(sql, connstr))
                {
                    atper.SelectCommand.CommandType = type;
                    if (pars != null)
                    {
                        atper.SelectCommand.Parameters.AddRange(pars);
                    }
                    DataTable da = new DataTable();
                    atper.Fill(da);
                    return da;
                }
            }
        }

        public static DataSet GetDataSet(string sql, CommandType type, params SqlParameter[] pars)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlDataAdapter atper = new SqlDataAdapter(sql, connstr))
                {
                    atper.SelectCommand.CommandType = type;
                    if (pars != null)
                    {
                        atper.SelectCommand.Parameters.AddRange(pars);
                    }
                    DataSet da = new DataSet();
                    atper.Fill(da);
                    return da;
                }
            }
        }



        public static int ExecuteNonQuery(string sql, CommandType type, params SqlParameter[] pars)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = type;
                    if (pars != null)
                    {
                        cmd.Parameters.AddRange(pars);
                    }
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string sql, CommandType type, params SqlParameter[] pars)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = type;
                    if (pars!=null)
                    {
                        cmd.Parameters.AddRange(pars);
                    }
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
