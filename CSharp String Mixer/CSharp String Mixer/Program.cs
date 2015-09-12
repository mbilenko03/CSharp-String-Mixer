using System;
using System.Collections.Generic;
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
        }

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
            Console.WriteLine(printReverse);           
        }
 
  }
}
