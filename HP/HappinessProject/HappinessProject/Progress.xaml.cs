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
    /// Interaction logic for Progress.xaml
    /// </summary>
    public partial class Progress : UserControl
    {
        public Progress()
        {
            InitializeComponent();
        }
        internal class ProgressInfo
        {
            public string KEVINPARK { get; private set; }
            public int Percentage { get; private set; }

            public ProgressInfo()
            {
                KEVINPARK = "aaaaaaaaaaaaaaaaaaaaa";
                Percentage = CalcularPorcentagem();
            }

            private int CalcularPorcentagem()
            {
                return 50; //Calculo da porcentagem de consumo
            }
        }
        internal class ProgressViewModel
        {
            public List<ProgressInfo> ProgressInfoList { get; private set; }

            public ProgressViewModel(ProgressInfo consumo)
            {
                ProgressInfoList = new List<ProgressInfo>();
                ProgressInfoList.Add(consumo);
            }
        }

        private void Btn_Checking_Click(object sender, RoutedEventArgs e)
        {
            Developing developing = new Developing();
            developing.Show();
        }
    }
}
