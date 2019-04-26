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
        Models.Task task = null;
        public StartTask()
        {
            InitializeComponent();
        }
        public StartTask(Models.Task taskGet)
        {
            InitializeComponent();
            task = taskGet;
            MessageBox.Show(task.taskID + " - " + task.score);
        }


        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_SetUpNextPlan_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Future Functionality. ");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Update Information in here.
            DAL dal = new DAL();
            // How to get specific information in here?
            // Need to find how..
        }
    }
}
