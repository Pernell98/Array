using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Program
{
    public class Primitives
    {
        public Primitives()
        {
            int [] integers = inputPrimitves();

            displayElements(integers);

            displayElementsBackwards(integers);
        }

        public int[] inputPrimitves()
        {
            int [] input = new int[3];

            for (int a = 0; a < input.Length; a++)
            {
                Console.WriteLine("enter each string");
                input[a] = int.Parse(Console.ReadLine());
            }

            return input;
        }

        public void displayElements(int[] array)
        {
            for (int a = 0; a < array.Length; a++)
            {
                Console.WriteLine(array[a]);
            }
        }

        public void displayElementsBackwards(int [] array)
        {
            for (int a = array.Length - 1; a < 0; a--)
            {
                Console.WriteLine(array[a]);
            }
        }
    }
}