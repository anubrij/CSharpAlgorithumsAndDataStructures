using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDS.Array
{
   public class ArraySolution
    {
        /// <summary>
        /// @Proble Statement : Implement an algorithm to determine if a string has all unique characters. What if you
        /// cannot use additional data structures?
        /// @Constraint :
        /// 1 <= s <= 10^3
        /// @Input:
        /// single string "S"
        /// @output:
        /// True or Flase
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsUnique(string s) {
            for (int i = 0; i < s.Length; i++) {
                if (i != s.LastIndexOf(s[i]))
                    return false;
            }
            return true;
        }
    }
}
