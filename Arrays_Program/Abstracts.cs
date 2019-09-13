using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Program
{
    public class Abstracts
    {
        private Nodes[] arrayOfNodes = new Nodes [3];
        public Abstracts()
        {
            Nodes [] arrayOfNodes  = inputNodes();

            displayNodes(arrayOfNodes);

            displayNodesBackwards(arrayOfNodes);
        }

        public Nodes[] inputNodes()
        {
            Nodes temp = new Nodes();

            for(int a = 0; a < arrayOfNodes.Length; a++ )
            {
                Console.WriteLine("enter node");
                temp.firstName = Console.ReadLine();

                arrayOfNodes[a] = temp;

            }

            return arrayOfNodes;
        }

        public void displayNodes(Nodes [] array)
        {
            for (int a = 0; a < array.Length; a++)
            {
                Console.WriteLine(array[a]);
            }
        }

        public void displayNodesBackwards(Nodes [] array)
        {
            for (int a = array.Length - 1; a < 0; a--)
            {
                Console.WriteLine(array[a]);
            }
        }
    }
}