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

namespace Pizzaria1
{
    /// <summary>
    /// Interaction logic for FirstTask.xaml
    /// </summary>
    public partial class FirstTask : UserControl
    {

        private static FirstTask _instance;
        public static FirstTask Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new FirstTask();
                }
                return _instance;
            }
        }

        public FirstTask()
        {
            InitializeComponent();
        }
    }
}
