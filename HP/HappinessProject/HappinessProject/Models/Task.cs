using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappinessProject.Models
{
    public class Task
    {
        public int taskID { get; set; }
        public int userID { get; set; }
        public string task_name { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public Task()
        {
            startDate = DateTime.Now.Date;
            endDate = DateTime.Today.Date;
        }
    }
}
