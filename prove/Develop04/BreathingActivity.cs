using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{

  /*
   Name = "Breathing Activity"
   Description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
  */
  //Member Variables



  //Constructors
  public BreathingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
  {

  }


  //Methods (Getters & Setters)



  //Methods 
  public void Run()
  {
    Console.WriteLine("You will breath in and out in equal 5 second measurements.");

    Pause(5);

    int time = GetDuration();
    int breathInDuration = 5;
    int breathOutDuration = 5;

    var stopwatch = new Stopwatch();

    string breathIn = "Breath In ... ";
    string breathOut = "Breath Out ... ";

    Console.Clear();
    stopwatch.Start();

    while (stopwatch.Elapsed < TimeSpan.FromSeconds(time))
    {
      Console.WriteLine(breathIn);
      CountDown(breathInDuration);
      Console.Clear();
      Console.WriteLine(breathOut);
      CountDown(breathOutDuration);
      Console.Clear();
    }
  }

  public void BoxBreathing()  // Exceeding Requirments - Added an alterante Breathing Activity. 
  {
    Console.WriteLine("The practice of box breathing, has you breathing in, holding your breath, and breathing out, in equal counts of 4. This exercise will run for the closes multiple of 16 to your selected time. ");

    Pause(8);

    int time = GetDuration();
    int breathInDuration = 4;
    int holdBreath = 4;
    int breathOutDuration = 4;

    var stopwatch = new Stopwatch();

    string breathIn = "Breath In ... ";
    string breathOut = "Breath Out ... ";
    string breathHold = "Hold Breath ... ";

    Console.Clear();
    stopwatch.Start();

    while (stopwatch.Elapsed < TimeSpan.FromSeconds(time))
    {
      Console.WriteLine(breathIn);
      CountUp(breathInDuration);
      Console.Clear();
      Console.WriteLine(breathHold);
      Pause(holdBreath);
      //CountDown(holdBreath);
      Console.Clear();
      Console.WriteLine(breathOut);
      CountDown(breathOutDuration);
      Console.Clear();
      Console.WriteLine(breathHold);
      Pause(holdBreath);
      //CountDown(holdBreath);
      Console.Clear();
    }
  }
}