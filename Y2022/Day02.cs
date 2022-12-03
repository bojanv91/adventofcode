namespace Y2022
{
    /// <summary>
    /// Day 2: Rock Paper Scissors
    /// </summary>
    public class Day02 : IDay
    {
        public int Part1()
        {
            var preCalculatedScores = new Dictionary<string, int>
            {
                // --part 1
                // draw pairs
                { "AX", 3 + 1 },
                { "BY", 3 + 2 },
                { "CZ", 3 + 3 },
                // winning pairs
                { "CX", 6 + 1 },
                { "AY", 6 + 2 },
                { "BZ", 6 + 3 },
                // lossing pairs
                { "AZ", 0 + 3 },
                { "BX", 0 + 1 },
                { "CY", 0 + 2 }
            };

            var result = File.ReadAllLines("./Day02.txt")
                .Sum(x => preCalculatedScores[string.Concat(x[0], x[2])]);

            return result;
        }

        public int Part2()
        {
            var preCalculatedScores = new Dictionary<string, int>
            {
                // --part 2
                // draw pairs
                { "AY", 3 + 1 },
                { "BY", 3 + 2 },
                { "CY", 3 + 3 },
                // winning pairs
                { "AZ", 6 + 2 },
                { "BZ", 6 + 3 },
                { "CZ", 6 + 1 },
                // lossing pairs
                { "AX", 0 + 3 },
                { "BX", 0 + 1 },
                { "CX", 0 + 2 }
            };

            var result = File.ReadAllLines("./Day02.txt")
                .Sum(x => preCalculatedScores[string.Concat(x[0], x[2])]);

            return result;
        }

        //// --original
        //// draw pairs
        //{ "AA", 3 + 1 },
        //{ "BB", 3 + 2 },
        //{ "CC", 3 + 3 },
        //// winning pairs
        //{ "CA", 6 + 1 },
        //{ "AB", 6 + 2 },
        //{ "BC", 6 + 3 },
        //// lossing pairs
        //{ "AC", 0 + 3 },
        //{ "BA", 0 + 1 },
        //{ "CB", 0 + 2 },
    }
}
