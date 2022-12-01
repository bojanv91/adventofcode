namespace Y2022
{
    /// <summary>
    /// Day 1: Calorie Counting
    /// </summary>
    public class Day01 : IDay
    {
        public void Part1()
        {
            var result = File.ReadAllLines("./Day01.txt")
                .Aggregate(new List<long>() { 0 }, (totals, inputItem) =>
                    {
                        if (string.IsNullOrEmpty(inputItem))
                            totals.Add(0);
                        else
                            totals[^1] += long.Parse(inputItem);
                        return totals;
                    })
                .Max();

            Console.WriteLine(result);
        }

        public void Part2()
        {
            var result = File.ReadAllLines("./Day01.txt")
                .Aggregate(new List<long>() { 0 }, (totals, inputItem) =>
                {
                    if (string.IsNullOrEmpty(inputItem))
                        totals.Add(0);
                    else
                        totals[^1] += long.Parse(inputItem);
                    return totals;
                })
                .OrderByDescending(x => x)
                .Take(3)
                .Sum();

            Console.WriteLine(result);
        }
    }
}
