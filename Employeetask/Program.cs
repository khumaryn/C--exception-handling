using System;

namespace Employeetask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayi daxil et");
            int count = Convert.ToInt32(Console.ReadLine());
            Employee[] employees = new Employee[count];
            for (int i = 0; i < employees.Length; i++)
            {
                Console.Write($"{i+1}.Fullname:");
                string fullname = Console.ReadLine();
                Console.Write($"{i+1}.Age:");
                byte age = Convert.ToByte(Console.ReadLine());
                Console.Write($"{i+1}.Salary:");
                double salary = Convert.ToDouble(Console.ReadLine());
                Console.Write($"{i+1}.Position:");
                string position = Console.ReadLine();
                employees[i] = new Employee(fullname, age);
                employees[i].Position = position;
                employees[i].Salary = salary;

            }
            Console.WriteLine("All Employees");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i].Getinfo());
            }
            string ans;
            do
            {
                Console.WriteLine("axtaris etmek istiyrsinizmi? y/n");
                ans = Console.ReadLine();
                if (ans == "y")
                {
                    Console.WriteLine("deyeri daxil et");
                string search = Console.ReadLine();
                    Console.WriteLine("isciler axtarilir");
                    for (int i = 0; i < employees.Length; i++)
                    {
                        if (employees[i].Fullname.Contains(search))
                        {
                            Console.WriteLine(employees[i].Getinfo());
                        }
                    }
                }
                if (ans=="n")
                {
                    Console.WriteLine("proses bitdi");    
                }
                    

            } while (ans!="y" && ans!="n");
            


            
            





        }


    }
}   