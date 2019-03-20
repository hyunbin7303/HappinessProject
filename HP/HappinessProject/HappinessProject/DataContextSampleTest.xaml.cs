using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HappinessProject
{
    /// <summary>
    /// Interaction logic for DataContextSampleTest.xaml
    /// </summary>
    public partial class DataContextSampleTest : Window
    {
        public DataContextSampleTest()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void btnUpdateSource_Click(object sender, RoutedEventArgs e)
        {

            BindingExpression binding = txtWindowTitle.GetBindingExpression(System.Windows.Controls.TextBox.TextProperty);
            binding.UpdateSource();
        }
    }   
}
