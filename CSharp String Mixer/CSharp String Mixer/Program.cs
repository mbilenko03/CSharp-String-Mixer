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
        Reverser(useTerm);
        CaseSwitch(useTerm); 
        Randomizer(useTerm);
        }

    #region Reverser
    static void Reverser(char[] arrString)
        {
          char[] reverseArray = new char[arrString.Length];
        
        for(int i = 0; i < arrString.Length; i++)
            {
            int reverseHolder = (arrString.Length - 1 - i);
            char reverse = arrString[reverseHolder];
            reverseArray[i] = reverse;
            }

            string printReverse = new string(reverseArray);
            Console.WriteLine("Reverse: " + printReverse);           
        }
    #endregion

    #region CaseSwitcher 
    static void CaseSwitch(char[] arrString)
    {
      char[] caseFlip = new char[arrString.Length];
       char noCase = ' ';
       bool result = true;

       for(int i = 0; i < arrString.Length; i++)
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
           caseFlip[i] = noCase;
           result = false; 
         }
       }
       string printCaseFlip = new string(caseFlip);
       Console.WriteLine("CaseFlip: " + printCaseFlip);
       
       if (result == false)
       {
         Console.WriteLine("There were some input values that could not switch case. They were replaced with a space.");
       }
    }
    #endregion

    #region Randomizer
    static void Randomizer(char[] arrString)
    {
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

        Debug.WriteLine("Processed index: " + arrIndex);
      }

      string printRandomizer = new string(RandomArray);
      Console.WriteLine("Randomizer: " + printRandomizer);

    }
    #endregion
  }
}
