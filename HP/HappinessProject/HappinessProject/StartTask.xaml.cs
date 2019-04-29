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
using System.Windows.Shapes;

namespace HappinessProject
{
    /// <summary>
    /// Interaction logic for BreakcanceWindow.xaml
    /// </summary>
    public partial class StartTask : Window
    {
        public bool TaskStart = false;
        Models.Task task = null;
        public StartTask()
        {
            InitializeComponent();
        }
        public StartTask(Models.Task taskGet)
        {
            InitializeComponent();
            task = taskGet;
            InitValues();
        }
        private void InitValues()
        {
            lab_mainwork.Content = task.task_name;
            lab_startDate.Content = task.startDate;
            lab_score.Content = task.score;
            pbStatus.Value = task.score;
            txtBlock_Description.Text = task.description;
        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Start_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Start This Task.");
            // Button Text Change
            TaskStart = true;
            if(TaskStart)
            {
                Btn_Start.Content = "Finish";

            }
        }

        private void Btn_ResultReport_Click(object sender, RoutedEventArgs e)
        {
            ResultReport report = new ResultReport();
            report.Show();
        }
    }
}
 