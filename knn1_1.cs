using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            uint count = 2;            
            String [] array = new String[count];

            for (int i = 0; i < count; i++)
            {   
                    array[i] = Console.ReadLine();  
            }

            for (int i = 0; i < count; i++)
            {
                array[i] = array[i].Insert(0, "X: ");
                int indComa = array[i].IndexOf(",");
                array[i] = array[i].Insert(indComa + 1, " Y: ");
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
    }
}
