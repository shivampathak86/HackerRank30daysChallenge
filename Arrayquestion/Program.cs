using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayquestion
{
    public class Person
    {




        public int age;
        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge
            if (initialAge < 0)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            if (initialAge > 0)
            {
                age = initialAge;
            }

        }
        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console 
            if (age < 13)
                Console.WriteLine("You are young.");
            if (age >= 13 && age < 18)
                Console.WriteLine("You are a teenager.");
            if (age > 18)
                Console.WriteLine("You are old.");
        }

        //public void yearPasses();
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int n = int.Parse(Console.ReadLine());
            char[] words = new char[] { };
            //string S=Console.ReadLine();
            for (int i = 1; i <= n; i++)
            {
                string S = Console.ReadLine();

                words = S.Trim().ToCharArray();

            }

        }


    }

    }



