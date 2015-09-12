using StringMixerUtils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_String_Mixer
{
  class Program
  {
    static void Main(string[] args) 
        {
        string readTerm = Console.ReadLine(); 
        char[] useTerm = readTerm.ToCharArray();
        string result = StringReverser.Reverse(useTerm);
        Console.WriteLine("Reversed string: " + result);
        result = CaseSwitcher.CaseSwitch(useTerm);
        Console.WriteLine("Cases switch: " + result);
        result = Randomizer.Randomize(useTerm);
        Console.WriteLine("Randomizer: " + result);
        }
  }
}
