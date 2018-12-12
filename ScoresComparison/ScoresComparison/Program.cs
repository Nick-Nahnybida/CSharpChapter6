using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ScoresComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int input;
                const int MAX = 100;
                const int MIN = 0;
                int i;
                int[] scores = new int[4];

                for (i = 0; i < scores.Length; i++)
                {
                    WriteLine("Please enter test score {0}", (i + 1));
                    input = Convert.ToInt32(ReadLine());
                    if (input >= MIN && input <= MAX)
                    {
                        scores[i] = input;
                    }
                    else
                    {
                        WriteLine("Really?");
                        i--;
                    }
                }

                if (scores[0] <= scores[1] && scores[1] <= scores[2] && scores[2] <= scores[3])
                {
                    WriteLine("Look at that, you actually kept improving");
                    for (i = 0; i < scores.Length; i++)
                    {
                        WriteLine("Score {0} was {1}", (i + 1), (scores[i]));
                    }
                }
                else if (scores[0] >= scores[1] && scores[1] >= scores[2] && scores[2] >= scores[3])
                {
                    WriteLine("Did the tests get more difficult or did you study less and less?");
                    for (i = 0; i < scores.Length; i++)
                    {
                        WriteLine("Score {0} was {1}", (i + 1), (scores[i]));
                    }
                    WriteLine("Now, I'll go ahead and make that more desirable");
                    for (i = 3; i >= 0; i--)
                    {
                        WriteLine("Score {0} was {1}", (i + 1), (scores[i]));
                    }

                }

                else
                {
                    WriteLine("Lots of variation in your scores");
                    for (i = 0; i < scores.Length; i++)
                    {
                        WriteLine("Score {0} was {1}", (i + 1), (scores[i]));
                    }
                }
            }
        }

    }
}
