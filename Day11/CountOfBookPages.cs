using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    public class CountOfBookPages
    {
        public int GetRemainingChapters(int N, int[,] chapters, int K)
        {
            int remainingChapters = 0;

            for (int i = 0; i < N; i++)
            {
                int startPage = chapters[i, 0];
                int endPage = chapters[i, 1];

                if (startPage <= K && K <= endPage)
                {
                    remainingChapters = N - i;
                    break;
                }
            }

            return remainingChapters;
        }
    }
}
