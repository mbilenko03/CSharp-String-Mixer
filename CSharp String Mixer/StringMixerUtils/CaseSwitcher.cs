using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMixerUtils
{
  public static class CaseSwitcher
  {
    public static string CaseSwitch(char[] arrString)
    {
      if (arrString == null)
        return null;
      char[] caseFlip = new char[arrString.Length];

      for (int i = 0; i < arrString.Length; i++)
      {
        if (char.IsLower(arrString[i]))
        {
          caseFlip[i] = char.ToUpper(arrString[i]);
        }

        else if (char.IsUpper(arrString[i]))
        {
          caseFlip[i] = char.ToLower(arrString[i]);
        }

        else
        {
          caseFlip[i] = arrString[i];
        }
      }
      string printCaseFlip = new string(caseFlip);
      return printCaseFlip;
    }
  }
}
