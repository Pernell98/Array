using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Program
{
    public class Strings
    {

        public Strings()
        {
            string[] input = inputStrings();

            displayElements(input);
            displayElementsBackwards(input);
        }
        public void displayElements(string [] array)
        {
            for(int a =0; a < array.Length; a++)
            {
                Console.WriteLine(array[a]);
            }
        }

        public void displayElementsBackwards(string [] array)
        {
            for(int a = array.Length -1; a < 0; a--)
            {
                Console.WriteLine(array[a]);
            }
        }

        public string[] inputStrings()
        {
            string[] input = new string[3];

            for(int a = 0; a < input.Length; a++)
            {
                Console.WriteLine("enter each string");
                input[a] = Console.ReadLine();
            }

            return input;
        }
    }
}