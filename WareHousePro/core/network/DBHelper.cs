using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WareHousePro.core.network
{
    internal class DBHelper
    {
        private const string connectionString = "Server=HOSHIMI-MIYABI\\SQLEXPRESS;Database=StorageBookingProDB;Integrated Security=true;TrustServerCertificate=true";
        private static T Execute<T>(string query, Func<SqlCommand, T> func, params SqlParameter[] parameter)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    if (parameter.Length > 0) cmd.Parameters.AddRange(parameter);
                    conn.Open();
                    return func(cmd);
                }
            }catch (Exception ex)
            {
                throw new DataException("Error Database:", ex);
            }
        }

        public static object ExecuteScalar(string query, params SqlParameter[] parameter)
        {
            return Execute(query, cmd => cmd.ExecuteScalar(), parameter);
        }
        public static int ExecuteNonQuery(string query, params SqlParameter[] parameter)
        {
            return Execute(query, cmd => cmd.ExecuteNonQuery(), parameter);
        }
        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameter)
        {
            return Execute(query, cmd =>
            {
                using (var da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }, parameter);
        }
        public static List<T> ExecuteReader<T>(string query, Func<SqlDataReader, T> func, params SqlParameter[] parameter)
        {
            return Execute(query, cmd =>
            {
                using (var dr = cmd.ExecuteReader())
                {
                    List<T> list = new List<T>();
                    while (dr.Read())
                    {
                        list.Add(func(dr));
                    }
                    return list;
                }
            }, parameter);
        }
    }
}
