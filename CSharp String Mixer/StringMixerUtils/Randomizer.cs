using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMixerUtils
{
  public static class Randomizer
  {
    public static string Randomize(char[] arrString)
    {

      if (arrString == null)
        return null;
      Random r = new Random();
      char[] RandomArray = new char[arrString.Length];
      bool[] excludedNumbers = new bool[arrString.Length];

      for (int i = 0; i < arrString.Length; i++)
      {
        int arrIndex;
        do
        {
          arrIndex = r.Next(arrString.Length);
        }
        while (excludedNumbers[arrIndex] == true);

        RandomArray[i] = arrString[arrIndex];
        excludedNumbers[arrIndex] = true;

      }

      string printRandomizer = new string(RandomArray);
      return printRandomizer;

    
    }
  }
}
