namespace Y2022
{
    /// <summary>
    /// Day 3: Rucksack Reorganization
    /// </summary>
    public class Day03 : IDay
    {
        public int Part1()
        {
            var result = File.ReadAllLines("./Day03.txt")
                .SelectMany(x => x[0..(x.Length / 2)].Intersect(x[(x.Length / 2)..]))
                .Sum(x => char.IsUpper(x) ? x - 38 : x - 96); // based on ASCII math

            return result;
        }

        public int Part2()
        {
            var tempList = new List<string>();
            var result = File.ReadAllLines("./Day03.txt")
                .Aggregate(0, (accom, inputItem) =>
                {
                    tempList.Add(inputItem);
                    if (tempList.Count == 3)
                    {
                        accom += tempList[0].Intersect(tempList[1]).Intersect(tempList[2])
                            .Sum(x => char.IsUpper(x) ? x - 38 : x - 96); // based on ASCII math
                        tempList.Clear();
                    }
                    return accom;
                });

            return result;
        }
    }
}
