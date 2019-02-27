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

namespace Pizzaria1
{
    /// <summary>
    /// Interaction logic for GoalSetting.xaml
    /// </summary>
    public partial class FriendSetting
    {
        public FriendSetting()
        {
            InitializeComponent();
        }

        private void Btn_Lab1_Click(object sender, RoutedEventArgs e)
        {
            this.tabControl.SelectedIndex = 1;
        }

        private void Btn_Next_Click(object sender, RoutedEventArgs e)
        {
            this.tabControl.SelectedIndex = 2;
            UC_Julio uC_Julio = new UC_Julio();
           

        }
    }
}
