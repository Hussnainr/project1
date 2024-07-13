using System;
using System.Collections.Generic;
public class Book
{
    public string Title;
    public string Author;
    public int BookID;
    public void set(string Title, string Author, int BookID)
    {
        this.Title = Title;
        this.Author = Author;
        this.BookID = BookID;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {this.Title}");
        Console.WriteLine($"Author: {this.Author}");
        Console.WriteLine($"Book ID: {this.BookID}");
    }
}
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int PersonID { get; set; }
    public void set(string Name, int Age, int PersonID)
    {
        this.Name = Name;
        this.Age = Age;
        this.PersonID = PersonID;
    }
}
public class Library
{
    public string LibraryName;
    public int LibraryID;
    private List<Book> books; 
    
    public void set1(string LibraryName, int LibraryID)
    {
        this.LibraryName = LibraryName;
        this.LibraryID = LibraryID;
        books = new List<Book>();
    }
    public void get()
    {
        Console.WriteLine("Library Name:" +this.LibraryName);
        Console.WriteLine("Library ID:" +this.LibraryID);
    }
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added to the library.");
    }
    public void RemoveBook(int bookID)
    {
        Book bookToRemove = books.Find(b => b.BookID == bookID);
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine($"Book with ID '{bookID}' removed from the library.");
        }
        else
        {
            Console.WriteLine($"Book with ID '{bookID}' not found in the library.");
        }
    }
    
    public void ViewBooks()
    {
        Console.WriteLine($"Books in Library '{LibraryName}' (ID: {LibraryID}):");
        foreach (Book book in books)
        {
            Console.WriteLine($"- {book.Title} by {book.Author} (ID: {book.BookID})");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Book book2 = new Book();
        Book book3 = new Book();
        book1.set(" A Time to Kill","John Grisham",100);
        book2.set("East of Eden" ,"John Steinbeck",101);
        book3.set("The Sun Also Rises","Ernest Hemingway",102);
        book1.DisplayInfo();
        book2.DisplayInfo();
        book3.DisplayInfo();
        Library lb = new Library();
        lb.set1("National Library",1001);
        lb.get();
        lb.AddBook(book1);
        lb.AddBook(book2);
        lb.AddBook(book3);
        lb.ViewBooks();
        lb.RemoveBook(102);
        lb.ViewBooks();
    }
}
