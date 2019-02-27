using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria1
{
    public class HP_Singleton
    {
        public ScoreEvaluation scoreEvaluation;

        private static HP_Singleton instance = null;
        private static readonly object padlock = new object();
        private HP_Singleton()
        {
            scoreEvaluation = new ScoreEvaluation();
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
