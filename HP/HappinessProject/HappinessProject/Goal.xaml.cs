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
    /// Interaction logic for DailyWork.xaml
    /// </summary>
    public partial class Goal : UserControl
    {
        public Goal()
        {
            InitializeComponent();
            
        }

        private void pythonExampleStart_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
        }

        private void pythonExampleDetail_Click(object sender, RoutedEventArgs e)
        {
            GoalViewDetail goalView = new GoalViewDetail();
            goalView.ShowDialog();
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            AddTask addTaskWindow = new AddTask();
            addTaskWindow.Show();

        }

        private void CancelTask_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
