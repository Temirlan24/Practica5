using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArray = 5;
            int[] arrayFirst = new int[sizeArray];
            int[] arraySecond = new int[sizeArray];
            ClassArray objectFirst = new ClassArray();
            objectFirst.stroka = "sfsdfs";
            ClassArray objectSecond = new ClassArray();
            objectSecond.stroka = "sfsdfs";
            if (objectFirst == objectSecond)
            {
                Console.WriteLine("Equal");
            }
            else if(objectFirst != objectSecond)
            {
                Console.WriteLine("Not Equal");
            }

            objectFirst.ReadArray(arrayFirst, sizeArray);
            objectFirst.ShowArray(arrayFirst);
            Console.WriteLine();
            objectSecond.ReadArray(arraySecond, sizeArray);
            objectSecond.ShowArray(arraySecond);
            Console.WriteLine();
            if (objectFirst > objectSecond)
            {
                Console.WriteLine("Sum of first array greater than sum of second array");
            }
            else
            {
                Console.WriteLine("Sum of first array not greater than sum of second array");
            }
            if (objectFirst < objectSecond)
            {
                Console.WriteLine("Sum of first array less than sum of second array");
            }
            else
            {
                Console.WriteLine("Sum of first array not less than sum of second array");
            }
            
            Console.ReadKey();
        }
    }
}
