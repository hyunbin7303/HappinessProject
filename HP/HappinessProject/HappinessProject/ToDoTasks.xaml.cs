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
    /// Interaction logic for ToDoTasks.xaml
    /// </summary>
    public partial class ToDoTasks : UserControl
    {
        public ToDoTasks()
        {
            InitializeComponent();
            DataContext = new MainDashViewModel();

        }

        private void lb_Tasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (ListBox)sender;
            var selectedTask = (Models.Task)item.SelectedItem;
            StartTask taskStart = new StartTask(selectedTask);
            taskStart.Show();
        }
    }
}
