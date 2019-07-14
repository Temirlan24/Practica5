using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ClassArray
    {
        public string stroka { get; set; }
        public int[] array { get; set; }
        public int sizeArray { get; set; }
        public ClassArray()
        {
        }
        public ClassArray(string stroka)
        {
            this.stroka = stroka;
        }
        public ClassArray(int[] array, int sizeArray)
        {
            this.sizeArray = sizeArray;
            for (int i = 0; i < sizeArray; i++)
            {
                this.array[i] = array[i];
            }
        }
        public void ReadArray(int[] array, int sizeArray)
        {
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < sizeArray; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
        public void ShowArray(int[] array)
        {
            Console.WriteLine("Элементы массива:");
            foreach (var element in array)
            {
                Console.Write(element + "\t");
            }
        }
        public static bool operator >(ClassArray firstArray, ClassArray secondArray)
        {
            int sumFirstArray = 0, sumSecondArray = 0;
            for (int i = 0, j = 0; i < firstArray.sizeArray && j < secondArray.sizeArray; i++, j++)
            {

                sumFirstArray += firstArray.array[i];
                sumSecondArray += secondArray.array[i];
            }
            return (sumFirstArray > sumSecondArray);
        }
        public static bool operator <(ClassArray firstArray, ClassArray secondArray)
        {
            int sumFirstArray = 0, sumSecondArray = 0;
            for (int i = 0, j = 0; i < firstArray.sizeArray && j < secondArray.sizeArray; i++, j++)
            {

                sumFirstArray += firstArray.array[i];
                sumSecondArray += secondArray.array[i];
            }
            return (sumFirstArray < sumSecondArray);
        }

        public static bool operator ==(ClassArray firstSroka, ClassArray secondStroka)
        {
            return (firstSroka.stroka == secondStroka.stroka);
        }
        public static bool operator !=(ClassArray firstSroka, ClassArray secondStroka)
        {
            return (firstSroka.stroka != secondStroka.stroka);
        }
    }
}
