using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator.Model
{
    public static class Multiplier
    {
        public static double Extensions(this StatisticMultiplier statisticMultiplier)
        {
            switch (statisticMultiplier)
            {
                case StatisticMultiplier.Low:
                    return 0.75;
                case StatisticMultiplier.Medium:
                    return 1.0;
                case StatisticMultiplier.High:
                    return 1.25;
             
            }
            return 0.0;
        }
    }
}
