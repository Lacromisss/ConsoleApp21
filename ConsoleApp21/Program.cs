using System;
using System.Net.Sockets;
using System.Xml.XPath;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int input;
            Console.WriteLine("ne qeder yaransin sec !!");
            input = int.Parse(Console.ReadLine());
            Book[] books = new Book[input];
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("kitab No");
                string no = Console.ReadLine();
                Console.WriteLine("kitab ad");
                string name = Console.ReadLine();
                Console.WriteLine("kitab  qiymet");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("kitab sayi");
                int count = int.Parse(Console.ReadLine());
                Console.WriteLine("Kitab janri");
                string genre = Console.ReadLine();
                books[i] = new Book(no, name, price, genre);

            }

            for (int j = 0; j < 999; j++)
            {



                Console.WriteLine("Menu");
                Console.WriteLine("1. Kitablari qiymete gore filterle");
                Console.WriteLine("2. Kitablar icinde axtaris");
                Console.WriteLine("3. Butun kitablari goster");
                Console.WriteLine("0. Proqrami bagla");

                Console.WriteLine("Yeniden sece bilersiz");
                int deyer = int.Parse(Console.ReadLine());






                switch (deyer)
                {

                    case 1:

                        Console.WriteLine("minimum deyeri girin");
                        int min = int.Parse(Console.ReadLine());
                        Console.WriteLine("max deyeri qebul edin");
                        int max = int.Parse(Console.ReadLine());

                        Book[] filteredBooks = filterBook(min, max, books);
                        foreach (var item in filteredBooks)
                        {
                            Console.WriteLine(item.GetInfo());

                        }

                        break;
                    case 2:
                        Console.WriteLine("axtardiqiniz kitabi daxil edin");
                        string filtstr = Console.ReadLine();
                        Book[] filter = filteredString(filtstr, books);
                        foreach (var abc in filter)
                        {
                            Console.WriteLine(abc.GetInfo());
                        }


                        break;
                    case 3:
                        Console.WriteLine("\n================================\n");
                        Console.WriteLine("Kitablar:");

                        for (int i = 0; i < books.Length; i++)
                        {
                            Console.WriteLine("--------------------------");
                            Console.WriteLine($"{i + 1}.Kitab ");
                            Console.WriteLine(books[i].GetInfo());
                        }

                        break;
                    case 0:
                        j =1000;

                       break;
                        


                }
            }



            static Book[] filterBook(int min, int max, Book[] books)
            {
                Book[] filtered;
                int count = 0;
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i].Price >= min && books[i].Price <= max)
                    {
                        count++;
                    }

                }

                filtered = new Book[count];
                count = 0;



                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i].Price >= min && books[i].Price <= max)
                    {
                        filtered[count] = books[i];
                        count++;

                    }

                }

                return filtered;


            }

            static Book[] filteredString(string name, Book[] books)
            {
                int count = 0;
                Book[] filter;


                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i].Name == name)
                    {
                        count++;

                    }

                }

                filter = new Book[count];
                count = 0;
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i].Name == name)
                    {
                        filter[count] = books[i];
                        count++;

                    }

                }

                return filter;









            }



        }
    }
}
