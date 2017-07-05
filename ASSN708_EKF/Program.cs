using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSN708_EKF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            int x, y, num;
            int sum = 0;
            string ystring, numstring;

            //User Input
            Console.WriteLine("How many integers will be added?");
            ystring = Console.ReadLine();
            y = Convert.ToInt32(ystring);

            //Loop
            for (x = 1; x <= y; x++)
            {
                //User Input
                Console.WriteLine("Enter an integer:");
                numstring = Console.ReadLine();
                num = Convert.ToInt32(numstring);
                //Process
                sum = num + sum;
            }//End Loop
        
            //Output
            Console.WriteLine();
            Console.WriteLine("The sum is {0}", sum);
            Console.ReadLine();

        }//End Main
    }//End Class
}//End Program
