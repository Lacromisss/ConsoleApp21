using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
    internal class Book:Product
    {
        public Book( string no,string name,int price,string genre):base(no,name,price)  
        {
            this.Genre = genre;
        }
        
        
        public string Genre;
        public void metod1()
        {
            

                Console.WriteLine("kitab no" + No);
                Console.WriteLine("kitab adi" + Name);
                Console.WriteLine("kitab qiymeti" + Price);
                Console.WriteLine("kitab sayi" + Count);
                Console.WriteLine("Kitab Janri" + Genre);

        }
        

        public string GetInfo()
        {
            return $"Kitab no: {this.No} - Adi: {this.Name} - Qiymeti: {this.Price} \n  - Janr: {this.Genre} ";
        }
    }
}
