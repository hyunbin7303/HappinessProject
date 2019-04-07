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
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
