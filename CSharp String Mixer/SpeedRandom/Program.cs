using StringMixerUtils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRandom
{
  class Program
  {
    static void Main(string[] args)
    {
      string readTerm = Console.ReadLine();
      char[] useTerm = readTerm.ToCharArray();      
      RandomItteration(useTerm);       
    }

    static void RandomItteration(char[] useTerm)
    {
      string compTerm = new string(useTerm);  
      string result;
      int i = 1;
      Stopwatch sw = new Stopwatch();
      sw.Start();
      do
      {
        result = Randomizer.Randomize(useTerm);
        Console.WriteLine("Randomizer[{0}]: {1}", i, result);
        i++;

      } while (result != compTerm);
      Console.WriteLine("It took {0} tries to get {1} in {2}.", i, compTerm, sw.Elapsed);
      sw.Stop();
    
    }
  }
}
