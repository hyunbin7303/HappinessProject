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
    public partial class GoalViewDetail : Form
    {
        public GoalViewDetail()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            txt_StartDate.Text = HP_Singleton.Instance.privateInfo.StartDate.ToLongDateString();
            txt_EndDate.Text = HP_Singleton.Instance.privateInfo.EndDate.ToLongDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_SelectedDate_TextChanged(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txt_SelectedDate.Text = monthCalendar1.SelectionRange.Start.ToString();

        }

        private void GoalViewDetail_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_StartDate_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
