using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ExtensionMethods
{
    public static class NumbersExtensions
    {
        public static double DivideBy(this double value, double divider)
        {
            return value / divider;
        }

        public static double DivideByZero(this double value)
        {
            return value / 0;
        }
    }
}
