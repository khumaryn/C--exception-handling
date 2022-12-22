using System;
using System.Security.Cryptography;

namespace notebookmenutask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks=new Notebook[4];
            notebooks[0] = new Notebook("Macbook Pro 15", 3500);
            notebooks[1] = new Notebook("Macbook Pro 13", 2500);
            notebooks[2] = new Notebook("Macbook Air", 1500);
            notebooks[3] = new Notebook("Asus ROG", 3200);
            string option;
            do
            {
                Console.WriteLine("1. Notebooklar uzerinde axtaris et");
                Console.WriteLine("2. Yeni notebook yarat");
                Console.WriteLine("0. Menudan cix");
                option = Console.ReadLine();
                if (option == "0")
                    Console.WriteLine("proses bitir");
                if (option == "1")
                    Console.WriteLine("notebookkae uzerinden axtaris ede bilersiz");
                string search = Console.ReadLine();
                var FilterArr = SearchByName(notebooks, search);
                Shownotebooksinfo(FilterArr);
                if (option == "2")
                    CreateNotebook();

            } while (option != "0");


        } static Notebook[] SearchByName(Notebook[] arr, string search)
        {
            Notebook[] newArr = new Notebook[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Name.Contains(search))
                { 
                Array.Resize(ref newArr, newArr.Length + 1);
                newArr[newArr.Length - 1] = arr[i];
                }
                    
            }
            return newArr;

        }
        static void Shownotebooksinfo(Notebook[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine( arr[i].GetInfo());
            }
        
        }
        static Notebook CreateNotebook()
        {
            do
            {Console.WriteLine("adi daxil et");
            string name=Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name) )
            {
                throw new NotebookNamePriceRamFormatException("Adi  daxil edin");
            }
            Console.WriteLine("qiymeti daxil et");
            double price=Convert.ToDouble(Console.ReadLine());
            if (price < 0)
            {
                throw new NotebookNamePriceRamFormatException("Reqem duzgun  daxil edin");
            }
            
            Console.WriteLine("Rami daxil et");
            byte Ram=Convert.ToByte(Console.ReadLine());
            if (Ram > 0) 
            {
                throw new NotebookNamePriceRamFormatException("Reqem duzgun  daxil edin");
            }



            Notebook notebook = new Notebook (name,price,Ram )
            {
                Name = name,
                Price = price,
                RAM=Ram
            };

            return notebook;


            } while (true);
            
        }




    }
}
