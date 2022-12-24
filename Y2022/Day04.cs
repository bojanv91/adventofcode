namespace Y2022
{
    /// <summary>
    /// Day 4: Camp Cleanup
    /// </summary>
    public class Day04 : IDay
    {
        public int Part1()
        {
            int pairsCountWithTotalOverlap = 0;
            var inputLines = File.ReadAllLines("./Day04.txt");
            foreach (var line in inputLines)
            {
                var index1 = line.IndexOf("-");
                var index2 = line.IndexOf(",");
                var index3 = line.LastIndexOf("-");

                var pair1 = (int.Parse(line[0..index1]), int.Parse(line[(index1 + 1)..index2]));
                var pair2 = (int.Parse(line[(index2 + 1)..index3]), int.Parse(line[(index3 + 1)..]));

                if (pair1.Item1 >= pair2.Item1 && pair1.Item2 <= pair2.Item2)
                    pairsCountWithTotalOverlap++;
                else if (pair2.Item1 >= pair1.Item1 && pair2.Item2 <= pair1.Item2)
                    pairsCountWithTotalOverlap++;
            }

            return pairsCountWithTotalOverlap;
        }

        public int Part2()
        {
            int pairsCountWithOverlap = 0;
            var inputLines = File.ReadAllLines("./Day04.txt");
            foreach (var line in inputLines)
            {
                var index1 = line.IndexOf("-");
                var index2 = line.IndexOf(",");
                var index3 = line.LastIndexOf("-");

                var pair1 = (int.Parse(line[0..index1]), int.Parse(line[(index1 + 1)..index2]));
                var pair2 = (int.Parse(line[(index2 + 1)..index3]), int.Parse(line[(index3 + 1)..]));

                if (IsBetween(pair1.Item1, pair2.Item1, pair2.Item2))
                    pairsCountWithOverlap++;
                else if (IsBetween(pair1.Item2, pair2.Item1, pair2.Item2))
                    pairsCountWithOverlap++;
                else if (IsBetween(pair2.Item1, pair1.Item1, pair1.Item2))
                    pairsCountWithOverlap++;
                else if (IsBetween(pair2.Item2, pair1.Item1, pair1.Item2))
                    pairsCountWithOverlap++;
            }

            return pairsCountWithOverlap;
        }


        bool IsBetween(int value, int start, int end)
        {
            return value >= start && value <= end;
        }
    }
}
