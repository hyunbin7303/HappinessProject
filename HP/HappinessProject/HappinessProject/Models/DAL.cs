using HappinessProject.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DdSetting
{
    public static class dbSetting
    {

    }
    public abstract class IDataMapper<T>
    {
        public IDbConnection Connection { get; private set; }
        public IDataMapper(IDbConnection connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("A valid database connection is required.");
            }
            this.Connection = connection;
        }

        public abstract List<T> Select(out Exception exError);
        public abstract bool Create(T instance, out Exception exError);
        public abstract T Read(int ID, out Exception exError);
        public abstract bool Update(T instance, out Exception exError);

    }

}

namespace HappinessProject
{


    // This class will be used for testing database management.
    public class DAL
    {
        private static string connectionString = string.Format("Server={0};Port={1};" +
        "User Id={2};Password={3};Database={4};",
        "127.0.0.1", "5432", "postgres",
        "Conestoga1", "HPdb");
        public NpgsqlConnection conn = new NpgsqlConnection(connectionString);
        public NpgsqlCommand cmd = new NpgsqlCommand();

        public static bool ConnectionNpg()
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                conn.Open();
                string sql = string.Format("SELECT user_name, user_id, user_description FROM hpschema.{0};", @"""User""");

                NpgsqlCommand command = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    Console.Write("{0}\t{1} \t{2} \n", dr[0], dr[1], dr[2]);

                }

                //    conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }



        public IList<User> userDisplay()
        {
            List<User> listUsers = new List<User>();
            try
            {
                conn.Open();
                string sql = string.Format("SELECT {0},{1},{2},{3} FROM hpschema.{4};", "id", @"""first_Name""", @"""last_Name""", "description", @"""User""");
                NpgsqlCommand command = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader dr = command.ExecuteReader();
    
                while (dr.Read())
                {
                    User user = new User();
                    user.user_id = Convert.ToInt32(dr["id"]);
                    user.FirstName = dr["first_Name"].ToString();
                    user.LastName = dr["last_Name"].ToString();
                    user.user_description = dr["description"].ToString();
                    listUsers.Add(user);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
            return listUsers;
        }
    }
}
