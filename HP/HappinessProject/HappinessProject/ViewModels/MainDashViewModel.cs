using HappinessProject.Models;
using League;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappinessProject.ViewModels
{

    public class MainDashViewModel : NotificationClass
    {
        public List<Task> taskCollection { get; set; }
        Business business;
        public EventHandler ShowMessageBox = delegate { };
        public MainDashViewModel()
        {
            business = new Business();
            GetDailyTask();
        }


        public void GetDailyTask()
        {
            DAL dal = new DAL();
            taskCollection = dal.TaskSelection().ToList();
        }


    }
}
