//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _6_November.Services
//{
//    internal class SQL
//    {
//        private const string _connectionString = "server=DESKTOP-CCR3N2B;database=AB104;Trusted_connection=true;integrated security=true;"; 
//        private static SqlConnection _connection= new SqlConnection(_connectionString);


//        public int ExecuteCommand(string command) {
//            int result = 0;
//            try
//            {
//                _connection.Open();
//                SqlCommand cmd = new SqlCommand(command);
//                result=cmd.ExecuteNonQuery();

//            }
//            catch (Exception e)
//            {

//                throw e;
//            }
//            finally 
//            {
//                _connection.Close(); 
//            }
//            return result;

//        }

//        public DataTable ExecuteQuery(string query) {
//            DataTable table = new DataTable();
//            try
//            {
//                _connection.Open();
//                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
//                adapter.Fill(table);
                

//            }
//            catch (Exception e)
//            {

//                throw e;
//            }
//      finally 
//            {
//                _connection.Close(); 
//            }
//        return table;
        
//        }







//    }
//}
