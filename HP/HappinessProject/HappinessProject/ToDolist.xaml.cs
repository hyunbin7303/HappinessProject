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
    /// Interação lógica para UserControlEscolha.xam
    /// </summary>
    public partial class ToDolist : UserControl
    {
        private static ToDolist _toDolist;
        public static ToDolist Instance
        {
            get
            {
                if(_toDolist == null)
                {
                    _toDolist = new ToDolist();
                }
                return _toDolist;
            }
        }


        public ToDolist()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ScoreTracker breakdance = new ScoreTracker();
            breakdance.Show();
        }

        private void Btn_Second(object sender, RoutedEventArgs e)
        {
            ScoreTracker programming = new ScoreTracker();
            programming.Show();
        }

        private void Btn_Third(object sender, RoutedEventArgs e)
        {
            ScoreTracker reading = new ScoreTracker();
            reading.Show();
        }
    }
}
