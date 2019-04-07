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
            if(connection == null)
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
    public static class SQLdb
    {
        private static string connectionString = string.Format("Server={0};Port={1};" +
        "User Id={2};Password={3};Database={4};",
        "127.0.0.1", "5432", "postgres",
        "Conestoga1", "HPdb");

        private static NpgsqlConnection conn = null;

        public static bool Connection(NpgsqlConnection conn)
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            return true;
        }
        public static bool ConnectionClose()
        {
            conn.Close();
            return true;
        }

        public static bool ConnectionNpg()
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                conn.Open();
                string sql = "SELECT id, tekst FROM public.simple_table;";
                NpgsqlCommand command = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    Console.Write("{0}\t{1} \n", dr[0], dr[1]);
                    
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }




    }
}
