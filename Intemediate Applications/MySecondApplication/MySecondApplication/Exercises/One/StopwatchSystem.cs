using System;
using System.Diagnostics;
using System.Threading;

namespace MySecondApplication.Exercises.One
{
  public class StopwatchSystem
  {
    // Save the time
    private TimeSpan Duration;
    // Control if the stopwatch is running
    private bool IsRunning;
    // Counter
    private readonly Stopwatch MyStopwatch;

    public StopwatchSystem()
    {
      this.Duration = new TimeSpan();
      this.IsRunning = false;
      this.MyStopwatch = new Stopwatch();
    }

    public TimeSpan GetDuration()
    {
      return this.Duration;
    }
    public void StartStopWatch()
    {
      if (this.IsRunning) {
        throw new InvalidOperationException("You can't start the stopwatch because it is already started");
      } else {
        this.IsRunning = true;
        this.MyStopwatch.Start();

      }

    }
    public void StopStopWatch()
    {
      if (!this.IsRunning) {
        Console.WriteLine("The Stopwatch is not running");
      } else {
        this.IsRunning = false;
        this.MyStopwatch.Stop();
        this.Duration = this.MyStopwatch.Elapsed;
      }
    }

    public void DisplayDuration()
    {
      if (!this.IsRunning) {
        Console.WriteLine("The duration is {0:00}:{1:00}:{2:00}.{3}",
                          this.Duration.Hours, this.Duration.Minutes, this.Duration.Seconds, this.Duration.Milliseconds);
      } else {
        Console.WriteLine("The StopWatch is already running");
      }
    }




  }
}
