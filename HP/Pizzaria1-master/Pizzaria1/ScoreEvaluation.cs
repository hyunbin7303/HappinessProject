using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria1
{
    public class ScoreEvaluation
    {
        public int IsStart { get; set; }
        public int ConcentrationLevel { get; set; }
        public int WorkLevel { get; set; }
        public int ExpectationMet { get; set; }
        public int IsFinishOnTime { get; set; }

        public ScoreEvaluation()
        {
            IsStart = 0;
            ConcentrationLevel = 0;
            WorkLevel = 0;
            ExpectationMet = 0;
            IsFinishOnTime = 0;
        }


        public int GetOverall()
        {
            int overall = IsStart + ConcentrationLevel + WorkLevel + ExpectationMet + IsFinishOnTime;
            return overall;
        }
    }
    public class PrivateInfo
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<string> TakingCourseName { get; set; }

    }
}
