using HappinessProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HappinessProject
{
    /// <summary>
    /// Interação lógica para UserControlInicio.xam
    /// </summary>
    public partial class MainDashboard : UserControl
    {
        public MainDashboard()
        {
            InitializeComponent();
            //DateLb.Content = getDate();
            DataContext = new MainDashViewModel();
        }

        private void Btn_Detail(object sender, RoutedEventArgs e)
        {
            ScoreTracker breakdance = new ScoreTracker();
            breakdance.Show();
        }


        private string getDate ()
        {
            string tdDate = String.Empty;
            tdDate = DateTime.Today.ToString("MMMM dd yyyy");
            return tdDate;
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void lb_Tasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Models.Task tempTask = new Models.Task();
            tempTask.startDate = "2019-01-20";
            tempTask.endDate = "2020-01-20";
            tempTask.taskID = 1;
            tempTask.task_name = "BreakDance";
            StartTask taskStart = new StartTask(tempTask);
            taskStart.Show();
        }
    }
}
