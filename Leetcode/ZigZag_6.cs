using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class ZigZag_6
    {
        public static string run(string s, int R)
        {
            if (s.Length <= R)
            {
                return s;
            }
            if (R <= 1)
            {
                return s;
            }

            int col = (s.Length / (R * 2 - 2)) + (s.Length % (R * 2 - 2) > 0 ? 1 : 0);
            string[] old = new string[col];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < col; i++)
            {
                if (i == col -1)
                {
                    old[i] = s.Substring(i * (R * 2 - 2));
                }
                else
                {
                    old[i] = s.Substring(i * (R * 2 - 2), R * 2 - 2);
                }
                
            }

            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == 0 || i == R - 1)
                    {
                        try
                        {
                            sb.Append(old[j][i]);
                        }
                        catch (Exception)
                        {
                        }
                    }
                    else
                    {
                        try
                        {
                            sb.Append(old[j][i]).Append(old[j][R * 2 - 2 - i]);
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
            return sb.ToString();
        }
    }
}
