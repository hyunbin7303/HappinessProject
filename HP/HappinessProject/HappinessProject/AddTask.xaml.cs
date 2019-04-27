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

    public partial class AddTask : Window
    {
        public AddTask()
        {
            InitializeComponent();
        }

        private void ApptDate_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Btn_AddTask_Click(object sender, RoutedEventArgs e)
        {
            DAL dal = new DAL();
            MessageBox.Show(date_Taskstart.SelectedDate.ToString() + " - " + date_Taskend.SelectedDate.ToString());
            Models.Task newTask = new Models.Task();
            dal.insertTask(newTask);
        }
    }
}
