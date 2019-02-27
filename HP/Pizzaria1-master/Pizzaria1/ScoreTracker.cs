using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria1
{
    public partial class ScoreTracker : Form
    {
        public ScoreTracker()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            pb_Overall.Value = 0;
            HP_Singleton hP_Singleton = HP_Singleton.Instance;
            hP_Singleton.scoreEvaluation.WorkLevel = Convert.ToInt32(cb_Workload.SelectedItem.ToString());
            if(cb_StartOnTime.SelectedItem.ToString() == "Yes")
                hP_Singleton.scoreEvaluation.IsStart = 5;
            else
                hP_Singleton.scoreEvaluation.IsStart = 0;

            if(cb_FinishOnTime.SelectedItem.ToString() == "Yes")
                hP_Singleton.scoreEvaluation.IsFinishOnTime = 5;
            else
                hP_Singleton.scoreEvaluation.IsFinishOnTime = 0;

            hP_Singleton.scoreEvaluation.ExpectationMet = Convert.ToInt32(cb_AchievementLevel.SelectedItem.ToString());
            hP_Singleton.scoreEvaluation.ConcentrationLevel = Convert.ToInt32(cb_Concentration.SelectedItem.ToString());
            int score = hP_Singleton.scoreEvaluation.GetOverall();
            score *= 4;
            MessageBox.Show(score.ToString());
            pb_Overall.Increment(score);
        }

        private void Breakdance_Load(object sender, EventArgs e)
        {
        }

        private void pb_Overall_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
