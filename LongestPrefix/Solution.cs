using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPrefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {

            string result = "";

            int min = strs[0].Length;

            foreach (var item in strs)
                min = item.Length < min ? item.Length : min;

            TrimItemsArray(strs, min);

            bool switcher = true;
            do
            {
                int counter = 0;
                for (int i = 0; i < strs.Length - 1; i++)
                {
                    if (string.Compare(strs[i], strs[i + 1]) == 0)
                    {
                        result = strs[i];
                        counter++;
                        if (counter == strs.Length - 1)
                            switcher = false;
                    }
                    else
                    {
                        result = "";
                        TrimItemsArray(strs, strs[i].Length - 1);

                    }
                }
            } while (switcher);

            return result;
        }

        private static string[] TrimItemsArray(string[] _arrayStr, int _trimIndex)
        {
            for (int i = 0; i < _arrayStr.Length; i++)
                _arrayStr[i] = _arrayStr[i].Substring(0, _trimIndex);

            return _arrayStr;
        }
    }
}
