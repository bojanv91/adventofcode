using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y2022.ForBenchmarkCode
{
    public class Day02v1 : IDay
    {
        public int Part1()
        {
            var result = File.ReadAllLines("./Day02.txt")
                .Sum(x => CalculateScore(x[0], Decrypt(x[2])));

            return result;
        }

        private static char Decrypt(char shape)
        {
            return shape switch
            {
                'X' => 'A',
                'Y' => 'B',
                'Z' => 'C',
                _ => ' ',
            };
        }

        private int CalculateScore(char them, char you)
        {
            int result;
            if (you == them)
                result = 3; // draw
            else if (you == 'A' && them == 'C' || you == 'B' && them == 'A' || you == 'C' && them == 'B')
                result = 6; // win
            else
                result = 0; // lose

            if (you == 'A')
                result += 1;
            else if (you == 'B')
                result += 2;
            else if (you == 'C')
                result += 3;

            return result;
        }

        public int Part2()
        {
            var result = File.ReadAllLines("./Day02.txt")
                .Sum(x => CalculateScore(x[0], Decrypt2(x[0], x[2])));

            return result;
        }

        private static char Decrypt2(char them, char yourResult)
        {
            char you;
            if (yourResult == 'Y') // draw
            {
                you = them;
            }
            else if (yourResult == 'Z') // win
            {
                if (them == 'A')
                    you = 'B';
                else if (them == 'B')
                    you = 'C';
                else
                    you = 'A';
            }
            else // lose
            {
                if (them == 'A')
                    you = 'C';
                else if (them == 'B')
                    you = 'A';
                else
                    you = 'B';
            }
            return you;
        }
    }
}
