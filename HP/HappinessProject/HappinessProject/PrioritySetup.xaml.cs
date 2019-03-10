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
    /// Interaction logic for PrioritySetup.xaml
    /// </summary>
    public partial class PrioritySetup : UserControl
    {
        public PrioritySetup()
        {
            InitializeComponent();
        }
        private void btn_AddImportantUrgent_Click(object sender, RoutedEventArgs e)
        {
            lb_IU.Items.Add(txt_AddImportantUrgent.Text);
            
        }
        private void btn_DeleteImportantUrgent_Click(object sender, RoutedEventArgs e)
        {
            lb_IU.Items.RemoveAt(lb_IU.Items.IndexOf(lb_IU.SelectedItem));
        }


        private void btn_AddImportantNotUrgent_Click(object sender, RoutedEventArgs e)
        {
            lb_IXU.Items.Add(txt_AddImportantNotUrgent.Text);
        }
        private void btn_DeleteImportantNotUrgent_Click(object sender, RoutedEventArgs e)
        {
            lb_IXU.Items.RemoveAt(lb_IXU.Items.IndexOf(lb_IXU.SelectedItem));
        }

        private void btn_AddNotImportantNotUrgent_Click(object sender, RoutedEventArgs e)
        {
            lb_XIXU.Items.Add(txt_AddNotImportantNotUrgent.Text);
        }

        private void btn_DeleteNotImportantNotUrgent_Click(object sender, RoutedEventArgs e)
        {
            lb_XIXU.Items.RemoveAt(lb_XIXU.Items.IndexOf(lb_XIXU.SelectedItem));

        }
    }
}
