using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftArray
{
    class Program
    {
        static int[] myArray = {1, 4, 6, 2, 1, 7, 4, 6, 2, 8}; 

        static int FirstUniqIterativ(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                bool foundDublicate = false; 
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (i != j && myArray[i] == myArray[j])
                    {
                        foundDublicate = true;
                        break;
                    }
                }

                if (!foundDublicate)
                    return i; 
            }
            return -1;

        }

        static int FirstUniqLambda(int[] myArray)
        {
            List<int> myList= myArray.ToList();
            for (int i = 0; i < myList.Count; i++)
            {
                int tal = myList[i];
                int firstIndex = myList.FindIndex((f => f == tal));
                int lastIndex = myList.FindLastIndex((f => f == tal));
                if (firstIndex == lastIndex)
                    return i;
            }
            return -1;

        }

        static void Main(string[] args)
        {

            Console.WriteLine(myArray[FirstUniqIterativ(myArray)]);
            Console.WriteLine(myArray[FirstUniqLambda(myArray)]);
            Console.ReadLine();
        }
    }
}
