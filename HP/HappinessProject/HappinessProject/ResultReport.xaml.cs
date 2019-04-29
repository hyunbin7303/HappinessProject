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
using System.Xml;
using System.Xml.Linq;

namespace HappinessProject
{
    public class TaskScoreReport
    {
        public string OnTime { get; set; }
        public string Concentration { get; set; }
        public string Completion { get; set; }
        public string Satisfaction { get; set; }
        public string FinishOnTime { get; set; }
        public int TotalMark()
        {
            int TaskScore = 0;
            if(OnTime == "Yes")
            {
                TaskScore += 5;
            }
            TaskScore += int.Parse(Concentration);
            TaskScore += int.Parse(Completion);
            TaskScore += int.Parse(Satisfaction);
            if(FinishOnTime == "Yes" || FinishOnTime == "YES")
            {
                TaskScore += 5;
            }
            return TaskScore;
        }
    }
    public partial class ResultReport : Window
    {
        public ResultReport()
        {
            InitializeComponent();
        }

        private void Btn_Confirm_Click(object sender, RoutedEventArgs e)
        {
            TaskScoreReport taskScoreReport = new TaskScoreReport();
            taskScoreReport.OnTime = cb_start.Text;
            taskScoreReport.Satisfaction = cb_Satisfaction.Text;
            taskScoreReport.Concentration = cb_Concentration.Text;
            taskScoreReport.Completion = cb_Completion.Text;
            taskScoreReport.FinishOnTime = cb_FinishOnTime.Text;

            using (XmlWriter writer = XmlWriter.Create("report.xml"))
            {
                writer.WriteStartElement("Report");
                writer.WriteElementString("OnTime", taskScoreReport.OnTime);
                writer.WriteElementString("Concentration", taskScoreReport.Concentration);
                writer.WriteElementString("Completion", taskScoreReport.Completion);
                writer.WriteElementString("Satisfaction", taskScoreReport.Satisfaction);
                writer.WriteElementString("FinishOnTime", taskScoreReport.FinishOnTime);
                writer.WriteElementString("TotalScore", taskScoreReport.TotalMark().ToString());
                writer.WriteEndElement();
                writer.Flush();
            }
        }
    }
}
