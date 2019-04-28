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
            Models.Task newTask = new Models.Task();

            // Setting up Task info.
            newTask.task_name = txt_name.Text;
            newTask.description = txt_description.Text;
            newTask.startDate= date_Taskstart.SelectedDate.ToString();
            newTask.endDate = date_Taskend.SelectedDate.ToString();
            newTask.userID = HP_Singleton.Instance.userID;
            if(dal.insertTask(newTask)) // Adding task into db.
            {
                MessageBox.Show("Success to add task.");
                return;
            }
            else
            {
                MessageBox.Show("Fail to add task into database.");
            }
        }
    }
}
