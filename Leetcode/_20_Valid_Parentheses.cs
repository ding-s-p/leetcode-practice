using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _20_Valid_Parentheses
    {
        static char[] re = new char[128];
        public static bool run(string s)
        {
            re[')'] = '(';
            re[']'] = '[';
            re['}'] = '{';

            var st = new Stack<char>(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    st.Push(s[i]);
                }
                else if (st.Count > 0 && s[i] < 128)
                {
                    if (re[s[i]] != st.Pop())
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return st.Count == 0;
        }
    }
}
