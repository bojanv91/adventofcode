namespace Y2022
{
    /// <summary>
    /// Day 1: Calorie Counting
    /// </summary>
    public class Day01 : IDay
    {
        public int Part1()
        {
            var result = File.ReadAllLines("./Day01.txt")
                .Aggregate(new List<int>() { 0 }, (totals, inputItem) =>
                    {
                        if (string.IsNullOrEmpty(inputItem))
                            totals.Add(0);
                        else
                            totals[^1] += int.Parse(inputItem);
                        return totals;
                    })
                .Max();

            return result;
        }

        public int Part2()
        {
            var result = File.ReadAllLines("./Day01.txt")
                .Aggregate(new List<int>() { 0 }, (totals, inputItem) =>
                {
                    if (string.IsNullOrEmpty(inputItem))
                        totals.Add(0);
                    else
                        totals[^1] += int.Parse(inputItem);
                    return totals;
                })
                .OrderByDescending(x => x)
                .Take(3)
                .Sum();

            return result;
        }
    }
}
