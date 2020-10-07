using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappinessProject.Models
{

    // Need to store task information ??? of the user???? 
    // but it is a solo application,,,,, why we need.........................................
    // Every user's information? 
    // Assumption : I got user's information when the program starts.  
    public class DailyLife
    {
        public string dateStr { get; set; }
        public int DailyScore { get; set; }
        public int Daily { get; set; }
        public int userID { get; set; }
        public User userInfo { get; set; }
        public List<Task> TaskID { get; set; } // all task information that user has. 
        public DailyLife()
        {
            userInfo = new User();

        }
    }
}
