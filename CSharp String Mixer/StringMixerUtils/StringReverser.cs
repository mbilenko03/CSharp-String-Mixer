using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMixerUtils
{
  public static class StringReverser
  {
    public static string Reverse(char[] arrString)
    {
      if (arrString == null)
        return null;

      char[] reverseArray = new char[arrString.Length];

      for (int i = 0; i < arrString.Length; i++)
      {
        int reverseHolder = (arrString.Length - 1 - i);
        char reverse = arrString[reverseHolder];
        reverseArray[i] = reverse;
      }

      string printReverse = new string(reverseArray);
 
      return printReverse;
    }
  }
}
