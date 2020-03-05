using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mas
{

    struct Empls

    {
        public string name;
        public int age;
        public decimal salary;
        public Empls(string n, int a, decimal s)
        {
            name = n; age = a; salary = s;
        }

        public void DisplayInfo()
        {

             

        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Empls[] empl = new Empls[3];
            for (int i = 0; i < empl.Length; i++)
            {

                Console.Write("Enter name employee: ");
                string n = Console.ReadLine();
                Console.Write("Enter age employee: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter salary amount employee: ");
                decimal s = Convert.ToDecimal(Console.ReadLine());
                empl[i] = new Empls(n, a, s);


            }

            Console.WriteLine("select an action: a = Min salary of employees; b = Max salary of employees; c = AVR age of employees");
            string selection = Console.ReadLine();
            

            switch (selection)

            {
                case "a":



                    decimal min = empl[0].salary;

                    for (int i = 0; i < empl.Length; i++)
                    {
                        if (min > empl[i].salary)
                            min = empl[i].salary;
                       
                    }

                    
                    Console.WriteLine($"Min salary ={min}");
                    


                    break;

                case "b":

                    decimal max = empl[0].salary;
                    for (int i = 0; i < empl.Length; i++)
                    {
                        if (max < empl[i].salary)
                            max = empl[i].salary;

                    }

                    Console.WriteLine($"Max salary = {max}");
                    break;

                case "c":

                    int avg = 0;
                    int agetotal = 0;
                    for (int i = 0; i < empl.Length; i++)
                    {
                        agetotal += empl[i].age;
                    }
                    avg = agetotal / empl.Length;
                    Console.WriteLine($"AVG = {avg}");

                    break;
                default:
                    Console.WriteLine("Wrong latter");
                    break;


            }
            Console.ReadKey();
        }


    }



   
}
