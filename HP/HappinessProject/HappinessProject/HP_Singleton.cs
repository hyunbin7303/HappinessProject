using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappinessProject
{
    public class HP_Singleton
    {
        public ScoreEvaluation scoreEvaluation;
        public PrivateInfo privateInfo;
        private static HP_Singleton instance = null;
        private static readonly object padlock = new object();
        private HP_Singleton()
        {
            scoreEvaluation = new ScoreEvaluation();
            privateInfo = new PrivateInfo();
            privateInfo.StartDate = new DateTime(2019, 2, 25);
            privateInfo.EndDate = new DateTime(2019, 3, 20);
        }
        public static HP_Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new HP_Singleton();
                        }
                    }
                }
                return instance;
            }
        }

    }
}
