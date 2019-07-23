using System;
using System.Collections.Generic;
using System.IO;

namespace Day13_Abstract
{
    abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();
    }

     class MyBook : Book
    {
        int priceBook;
        public MyBook(string t, string a, int price): base( t,  a)
        {
            this.priceBook = price;
        }
       
        public override void display()
        {
            Console.WriteLine("Title: {0}", this.title);
            Console.WriteLine("Author: {0}", this.author);
            Console.WriteLine("Price: {0}", priceBook);
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}
