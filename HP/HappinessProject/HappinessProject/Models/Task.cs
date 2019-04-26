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
        public string startDate { get; set; }
        public string endDate { get; set; }
        public int score { get; set; }

    }
}
