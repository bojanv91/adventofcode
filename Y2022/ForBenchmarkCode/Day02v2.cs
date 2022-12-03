using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y2022.ForBenchmarkCode
{
    public class Day02v2 : IDay
    {
        readonly Dictionary<char, int> _shapesScores = new()
        {
            { 'A', 1 },
            { 'B',  2 },
            { 'C', 3 }
        };

        public int Part1()
        {
            var decryptedShapeFor = new Dictionary<char, char>
            {
                { 'X', 'A' },
                { 'Y',  'B' },
                { 'Z', 'C' }
            };

            var result = File.ReadAllLines("./Day02.txt")
                .Sum(x => CalculateScore(x[0], decryptedShapeFor[x[2]]));

            return result;
        }

        private int CalculateScore(char opponentShape, char yourShape)
        {
            if (yourShape == opponentShape)
                return 3 + _shapesScores[yourShape]; // draw
            else if (yourShape == 'A' && opponentShape == 'C'
                || yourShape == 'B' && opponentShape == 'A'
                || yourShape == 'C' && opponentShape == 'B')
                return 6 + _shapesScores[yourShape]; // win
            else
                return 0 + _shapesScores[yourShape]; // lose
        }

        public int Part2()
        {
            var decryptedShapeFor = new Dictionary<string, char>
            {
                // draw pairs
                { "AY", 'A' },
                { "BY", 'B' },
                { "CY", 'C' },
                // winning pairs
                { "AZ", 'B' },
                { "BZ", 'C' },
                { "CZ", 'A' },
                // lossing pairs
                { "AX", 'C' },
                { "BX", 'A' },
                { "CX", 'B' }
            };

            var result = File.ReadAllLines("./Day02.txt")
                .Sum(x => CalculateScore(x[0], decryptedShapeFor[string.Concat(x[0], x[2])]));

            return result;
        }
    }
}
