using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_10_FormatException
{
    class Program
    {
        static void Main(string[] args)
        {
            double milesDriven = 0;
            double gallonsUsed = 0;
            try
            {
                Console.WriteLine("Please enter miles driven");
                milesDriven = Convert.ToDouble(Console.ReadLine());

                //if (milesDriven > 100)
                 //   throw new IndexOutOfRangeException();

               // Convert.ToChar(milesDriven);

                Console.WriteLine("Please enter gallons used");
                gallonsUsed = Convert.ToDouble(Console.ReadLine());

                double milesPerGallon = milesDriven / gallonsUsed;
                Console.WriteLine("Mileage is {0} miles per gallon", milesPerGallon);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input is Invalid!\n{0}", e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Please enter a correct mile.\n{0}",e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter correct Key?\n{0}", e.Message);
            }

            Console.ReadKey();
        }
    }
}
