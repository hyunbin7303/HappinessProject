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
    /// Interaction logic for SpecificDayCheck.xaml
    /// </summary>
    public partial class SpecificDayCheck : Window
    {

        private Models.Task task = null;
        public SpecificDayCheck()
        {
            InitializeComponent();
        }
        public SpecificDayCheck(Models.Task dayTask)
        {
            InitializeComponent();
            task = dayTask;

        }

        private static void Init_SpecificDayInfo()
        {

        }
    }
}
