using System.Diagnostics;

namespace MeaninglessBenchmarks;

public class StringIsEmpty
{
    public static Result[] Execute(Scenario[] scenarios)
    {
        var result = new Result[scenarios.Length];

        for (var i = 0; i < scenarios.Length; i++)
        {
            var scenario = scenarios[i];

            result[i] = new Result(scenario.Name, RunOn(scenario.Dummy));
        }

        return result;
    }

    private static Dictionary<string, long> RunOn(string dummy)
    {
        var stopwatch = new Stopwatch();
        var records = new Dictionary<string, long>();

        stopwatch.Start();

        if (dummy is {Length: > 0})
        {
        }

        stopwatch.Stop();
        records.Add("IsNullOrEmptyPattern", stopwatch.ElapsedTicks);
        stopwatch.Restart();

        if (string.IsNullOrEmpty(dummy))
        {
        }

        stopwatch.Stop();
        records.Add("IsNullOrEmpty", stopwatch.ElapsedTicks);
        stopwatch.Restart();

        if (dummy?.Trim() is {Length: > 0})
        {
        }

        stopwatch.Stop();
        records.Add("IsNullOrWhiteSpacePattern", stopwatch.ElapsedTicks);
        stopwatch.Restart();

        if (string.IsNullOrWhiteSpace(dummy))
        {
        }

        stopwatch.Stop();
        records.Add("IsNullOrWhiteSpace", stopwatch.ElapsedTicks);

        return records;
    }
}