using System.Data;
using System.Data.SqlClient;

namespace StudentCRUD.Models
{
    public class DataAccess
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = File.ReadAllText(_configuration["Path:ConnPath"]);
        }
        //public DataTable GetDataTable(string query, SqlParameter[] parameters = null)
        //{
        //    DataTable dt = new DataTable();
        //    using (SqlConnection con = new SqlConnection(_connectionString))
        //    {
        //        con.Open();
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            if (parameters != null)
        //            {
        //                cmd.Parameters.AddRange(parameters);
        //            }
        //            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        //            {
        //                da.Fill(dt);
        //            }
        //        }
        //    }
        //    return dt;
        //}
        //public int ExecuteQuery(string query, SqlParameter[] parameters = null)
        //{
        //    using (SqlConnection con = new SqlConnection(_connectionString))
        //    {
        //        con.Open();
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            if (parameters != null)
        //            {
        //                cmd.Parameters.AddRange(parameters);
        //            }
        //            return cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

        public DataTable GetDataTable(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public int ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
//using System.Data;
//using System.Data.SqlClient;

//namespace AuditPlanningSystem.Models
//{
//    public class DataAccess
//    {
//        private readonly IConfiguration _configuration;
//        private readonly string _connectionString;

//        public DataAccess(IConfiguration configuration)
//        {
//            _configuration = configuration;
//            _connectionString = _configuration.GetConnectionString("DefaultConnection");
//        }

        //public DataTable GetDataTable(string query, SqlParameter[] parameters = null)
        //{
        //    DataTable dt = new DataTable();
        //    using (SqlConnection con = new SqlConnection(_connectionString))
        //    {
        //        con.Open();
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            if (parameters != null)
        //            {
        //                cmd.Parameters.AddRange(parameters);
        //            }
        //            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        //            {
        //                da.Fill(dt);
        //            }
        //        }
        //    }
        //    return dt;
        //}

        //public int ExecuteQuery(string query, SqlParameter[] parameters = null)
        //{
        //    using (SqlConnection con = new SqlConnection(_connectionString))
        //    {
        //        con.Open();
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            if (parameters != null)
        //            {
        //                cmd.Parameters.AddRange(parameters);
        //            }
        //            return cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

        //public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        //{
        //    using (SqlConnection con = new SqlConnection(_connectionString))
        //    {
        //        con.Open();
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            if (parameters != null)
        //            {
        //                cmd.Parameters.AddRange(parameters);
        //            }
        //            return cmd.ExecuteScalar();
        //        }
        //    }
        //}
//    }
//}
