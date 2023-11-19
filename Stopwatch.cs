using System;

public class Stopwatch
{
    /* Class with Static members */
    private static DateTime? _time;
    private static TimeSpan _elapsedTime;

	public static DateTime Start()
    {
		if (_time == null)
        {
			_time = DateTime.Now;
            Console.WriteLine($"The current time is: {_time.Value}");
			return _time.Value;
        }
        else
        {
			throw new InvalidOperationException("Stopwatch has already been started.");
        }
    }

	public static TimeSpan Stop()
    {
        if (_time != null)
        {
			_elapsedTime = DateTime.Now - _time.Value;
			_time = null;
            Console.WriteLine($"Time elapsed: {_elapsedTime}. Resetting Stopwatch.");
			return _elapsedTime;
        }
        else
        {
            throw new InvalidOperationException("Stopwatch has not been started yet.");
        }
    }
}
