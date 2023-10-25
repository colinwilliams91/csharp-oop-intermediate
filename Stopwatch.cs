using System;

public class Stopwatch
{
    /* Class with Static members */
	
    public static DateTime? Time { get; set; }

	public static TimeSpan ElapsedTime { get; set; }

	public static DateTime Start()
    {
		if (Time == null)
        {
			Time = DateTime.Now;
            Console.WriteLine($"The current time is: {Time.Value}");
			return Time.Value;
        }
        else
        {
			throw new InvalidOperationException("Stopwatch has already been started.");
        }
    }

	public static TimeSpan Stop()
    {
        if (Time != null)
        {
			ElapsedTime = DateTime.Now - Time.Value;
			Time = null;
            Console.WriteLine($"Time elapsed: {ElapsedTime}. Resetting Stopwatch.");
			return ElapsedTime;
        }
        else
        {
            throw new InvalidOperationException("Stopwatch has not been started yet.");
        }
    }
}
