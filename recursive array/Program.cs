using System;
namespace recursive_array
{
    class Program
    {
        static void RecursiveArray(int[] array, int index)
        {

            if (index >= array.Length)
                return;

            Console.WriteLine(array[index]);

            index++;


            RecursiveArray(array, index);
        }

        static void Main(string[] args)
        {
             int[] myArray = new[] { 2, 2, 3, 4, 6, 7, 10};

            RecursiveArray(myArray, 4);

            Console.ReadLine();
        }
    }
}
