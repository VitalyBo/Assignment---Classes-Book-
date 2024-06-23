using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


//Vitalii Bobyr - 06/19/24
//Programming 120 - Code Practice - Assignment - Classes

namespace BookManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Book[] books = new Book[10]; // Array to store up to 10 Book objects
            int bookCount = 0; // Counter to keep track of the number of books
            bool condition =true;

            start:
            while (condition)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add a new book");
                Console.WriteLine("2. Display all books");
                Console.WriteLine("3. Update a book's information");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice: ");
                string choice = Console.ReadLine();

                try
                { 
                  switch(choice)  
                  {

                    case "1":
                        Console.WriteLine("Add a new book");
                            if (bookCount >= 10) { Console.WriteLine("The array is full. No more books can be added."); }
                                                         
                            else
                            {
                            Console.Write("Enter the title: ");
                                string title = Console.ReadLine();
                                Console.Write("Enter the author: ");
                                string author = Console.ReadLine();
                                Console.Write("Enter the year of publication: ");
                                int year = int.Parse(Console.ReadLine());

                                books[bookCount] = new Book(title, author, year);

                                bookCount++;
                            Console.WriteLine("Book added successfully.");
                            }

                        goto start;

                    case "2":
                        Console.WriteLine("Display all books");

                        if (bookCount == 0) { Console.WriteLine("No books to display."); }   
                        else
                        {
                             for (int i = 0; i < bookCount; i++) Console.WriteLine(books[i].ToString());                         
                        }
                        goto start;

                    case "3":
                        Console.WriteLine("Update a book's information");
                        Console.Write("Enter the title of the book to update: ");
                        string titleToUpdate = Console.ReadLine();
                        bool found = false;

                      for (int i = 0; i < bookCount; i++)
                      {
                        if (books[i].Title.Equals(titleToUpdate, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.Write("Enter the new title: ");
                            books[i].Title = Console.ReadLine();
                            Console.Write("Enter the new author: ");
                            books[i].Author = Console.ReadLine();
                            Console.Write("Enter the new year of publication: ");
                            books[i].Year = int.Parse(Console.ReadLine());
                            found = true;
                            Console.WriteLine("Book updated successfully.");
                         goto start;
                        }
                      }

                      if (!found) { Console.WriteLine("Book not found."); }
                        goto start;

                    case "4":
                        Console.WriteLine("Exit");
                            condition = false;
                        break;
                            
                  }
                                                      
                }
                catch 
                { 
                  Console.WriteLine("Invalid choice. Please try again.");
                    goto start;
                }
            }

        
        }
    }
}
    
    

    public class Book
    {
        private string title;
        private string author;
        private int year;

        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int Year
        {   
            get { return year; }
            set { year = value; }
        }

        
        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Year: {Year}";
        }
    }
















