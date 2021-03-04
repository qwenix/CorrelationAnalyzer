using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correlation.Models {
    public static class AppExtensions {
        public static int RoundToDecimal(this double number) {
            int res = (int)number;
            int rem = res % 10;
            if (rem >= 5)
                return res + (10 - rem);
            else
                return res - rem;
        }

        public static int RoundToHalfDecimal(this double number) {
            int res = (int)number;
            int rem = res % 5;
            if (rem >= 3)
                return res + (5 - rem);
            else
                return res - rem;
        }

        public static int RoundToDecimal(this int number) {
            return ((double)number).RoundToDecimal();
        }

        public static int RoundToHalfDecimal(this int number) {
            return ((double)number).RoundToHalfDecimal();
        }

        public static string ToIntString(this object o) {
            string s = o.ToString();
            string[] arr = s.Split('.');
            if (arr.Length == 2 && arr[1] == "0")
                return arr[0];
            else return s;
        }
    }
}
