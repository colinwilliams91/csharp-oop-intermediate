using System;

public class Stopwatch
{
    /* Class with Static members */
    private static DateTime? _time;
    private static TimeSpan _elapsedTime;

	public static DateTime Start()
    {
		if (_time != null)
        {
			throw new InvalidOperationException("Stopwatch has already been started.");
        }

        _time = DateTime.Now;
        Console.WriteLine($"The current time is: {_time.Value}. Stopwatch started.");
        return _time.Value;
    }

	public static TimeSpan Stop()
    {
        if (_time == null)
        {
            throw new InvalidOperationException("Stopwatch has not been started yet.");
        }

		_elapsedTime = DateTime.Now - _time.Value;
		_time = null;
        Console.WriteLine($"Stopwatch stopped. Time elapsed: {_elapsedTime}. Resetting Stopwatch.");
		return _elapsedTime;
    }
}
