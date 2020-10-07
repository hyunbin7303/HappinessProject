using HappinessProject.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;

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
        "localhost", "5432", "postgres",
        "Cc7594435", "HPdb");
        public NpgsqlConnection conn = new NpgsqlConnection(connectionString);
        public IList<User> userDisplay()
        {
            List<User> listUsers = new List<User>();
            try
            {
                conn.Open();
                string sql = string.Format("SELECT {0},{1},{2},{3} FROM hpschema.{4};", "id", @"""fName""", @"""lName""", "description", @"""User""");
                NpgsqlCommand command = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader dr = command.ExecuteReader();
    
                while (dr.Read())
                {
                    User user = new User();
                    user.user_id = Convert.ToInt32(dr["id"]);
                    user.FirstName = dr["fName"].ToString();
                    user.LastName = dr["lName"].ToString();
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
        public void GetConnection()
        {
        }
        // How to get column number? 
        static void HasRows(NpgsqlConnection connection, string tableName)
        {
            string tableNameCheck = @"""User""";
            string sql = string.Format("SELECT * FROM hpschema.{0};", tableNameCheck);
            using (connection)
            {
                NpgsqlCommand cmd = new NpgsqlCommand(sql);
                connection.Open();
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        
                    }
                }
                reader.Close();
            }
        }

        public IList<Task> TaskSelection()
        {
            List<Task> Tasks = new List<Task>();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM Proc_DisplayTaskInfo(1)";
                NpgsqlCommand command = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    Task task = new Task();
                    task.taskID = Convert.ToInt32(dr["taskid"]);
                    task.task_name = dr["tname"].ToString();
                    task.description = dr["description"].ToString();
                    task.startDate = dr["startdate"].ToString();
                    task.endDate = dr["enddate"].ToString();
                    task.score = Convert.ToInt32(dr["score"]);
                    Tasks.Add(task);
                }   
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
            return Tasks;
        }

        public IList<DailyLife> DisplayDailyLife(int userID)
        {
            List<DailyLife> dailyLives = new List<DailyLife>();
            try
            {
                conn.Open(); // Check for stored procedure is working or not.
                string sql = "SELECT * FROM Proc_DisplayTaskInfo(" + userID + ")"; // Need to make a stored procedure for this one.
                NpgsqlCommand command = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    DailyLife daily = new DailyLife();
                    dailyLives.Add(daily);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
            return dailyLives;
        }


        // Generate only today information temporary.
        public bool StoreTodayData(User user, List<Task> todayTasks)
        {
            //Getting Today Date.
            DateTime date = DateTime.Today;
            DailyLife dailyLife = new DailyLife();
            string dateStr = date.ToShortDateString();
            try
            {
                using (XmlWriter writer = XmlWriter.Create(dateStr))
                {
                    writer.WriteStartElement(dateStr);
                    foreach(Task task in todayTasks)
                    {
                        writer.WriteElementString("username", user.FirstName + " - " + user.LastName);
                        writer.WriteElementString("Task", user.FirstName + " - " + user.LastName);
                        writer.WriteElementString("username", user.FirstName + " - " + user.LastName);
                    }

                }
            }catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool TodayTaskInfoGenerate(Task oneTask)
        {
            DateTime date = DateTime.Now;
            string FileName = "Task" + date.Day + ".xml";
            using (XmlWriter writer = XmlWriter.Create(FileName))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Task" + oneTask.task_name);
                writer.WriteElementString("Name", oneTask.task_name);
                writer.WriteElementString("Score", oneTask.score.ToString());
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            return true;
        }


        public bool insertTask(Models.Task newTask)
        {
            try
            {
                conn.Open();
                string sql= string.Format("SELECT * FROM Proc_InsertTaskTest('{0}', '{1}', {2})", newTask.task_name, newTask.description,newTask.userID);
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.ExecuteNonQuery(); // Return value check please.
                conn.Close();

            }
            catch (NpgsqlException sqlex)
            {
                conn.Close();
                return false;
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }

            return true;
        }
    }
}
