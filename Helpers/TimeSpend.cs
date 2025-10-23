using System.Diagnostics;

namespace TestProject.Helpers;

public static class TimeSpend
{
  internal static void DeltaSpendTime(string label, Action act)
  {
    Console.WriteLine(" ");
    var sw = new Stopwatch();
    sw.Start();
    act();
    sw.Stop();
    Console.WriteLine($"\n{label} : {sw.Elapsed} \n");
  }
}
