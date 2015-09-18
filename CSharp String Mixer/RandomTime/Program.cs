using StringMixerUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTime
{
  class Program
  {
    static void Main(string[] args)
    {
      result = Randomizer.Randomize(useTerm);
      Console.WriteLine("Randomizer: " + result);
      result = Randomizer.Randomize(useTerm);
      Console.WriteLine("Randomizer: " + result);
    }
  }
}
