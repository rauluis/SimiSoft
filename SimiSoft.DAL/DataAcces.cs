using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.DAL
{
   public  class DataAcces
    {
        //singleton

        #region Singleton
        private static volatile DataAcces instance = null;
        private static readonly object padlock = new object();
        public static string conString = "Server=DESKTOP-FH5QEGN; DataBase=Simi DB; User Id =rizo;Password=123;";
       // public static string conString = "Data Source=DESKTOP-FH5QEGN;Initial Catalog=Simi DB;Integrated Security=True; User Id =rizo;Password=123;";

        private DataAcces(){ }

        public static DataAcces Instance()
        {
            if(instance == null)
                 lock (padlock)
                    if(instance == null)
                       instance = new DataAcces();
            return instance;
            
        }

        #endregion

        #region Query/Execute Dapper
        public T QuerySingle<T>(string query)
        {
            using (var con = new SqlConnection(conString))//Se crea una concexion con la base de datos con un string sql
                return con.QuerySingle<T>(query, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: 300);

            //ya regresaria el resultado de la clase

        }

       
        public T QuerySingle<T>(string query, DynamicParameters dynamicParameters)
        {
            using (var con = new SqlConnection(conString))
                return con.QuerySingle<T>(query, dynamicParameters, commandType: System.Data.CommandType.StoredProcedure, 
                    commandTimeout: 300);


        }


        public T QuerySingleOrDefault<T>(string query)
        {
            using (var con = new SqlConnection(conString))
                return con.QuerySingleOrDefault<T>(query, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: 300);
            //si no encuentra nada, el resulto regresa un nullo
        }

        public T QuerySingleOrDefault<T>(string query, DynamicParameters dynamicParameters)
        {
            using (var con = new SqlConnection(conString))
                return con.QuerySingleOrDefault<T>(query,dynamicParameters, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: 300);
        }

        public string QueryString(string query)
        {
            
            using (var con = new SqlConnection(conString))
                return con.QuerySingle(query, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: 300);
        }

        public string QueryString(string query, DynamicParameters dynamicParameters)
        {
            
            using (var con = new SqlConnection(conString))
                return con.QuerySingle(query,dynamicParameters, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: 300);
        }

        public List<T> Query<T>(string query)
        {
            using (var con = new SqlConnection(conString))
                return con.Query<T>(query, commandType: System.Data.CommandType.StoredProcedure,
                    commandTimeout: 300).ToList();


        }

        public List<T> Query<T>(string query,DynamicParameters dynamicParameters)
        {
            using (var con = new SqlConnection(conString))
                return con.Query<T>(query,dynamicParameters, commandType: System.Data.CommandType.StoredProcedure,
                    commandTimeout: 300).ToList();
                    }

        public int Insert(string query,DynamicParameters dynamicParameters,string fieldName)
        {
            using (var con = new SqlConnection(conString))
                return (int)((IDictionary<string, object>)con.QuerySingle(query, dynamicParameters, commandType: System.Data.CommandType.StoredProcedure,
                    commandTimeout: 300))[fieldName];

           
        }
        public int Excute(string query)
        {
            using (var con = new SqlConnection(conString))
                return con.Execute(query, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: 300);

        }

        public int Excute(string query, DynamicParameters dynamicParameters)
        {
            using (var con = new SqlConnection(conString))
                return con.Execute(query,dynamicParameters, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: 300);

        }
        #endregion

    }
}
