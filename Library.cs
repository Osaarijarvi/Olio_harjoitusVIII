using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Olio_harjoitusVIII;


// TASK 1 STEP 2

// class "Library"
public class Library

{

    //Empty list for library books
    List<Book> collection = new List<Book>();


    // Method for adding books to the collection
    public void AddBook(Book book)
    {
        Console.WriteLine($"Olio luotu: {book}.");
        collection.Add(book);
        Console.WriteLine($"{book.Name} lisätty.");
    }


    /* Method for removing a book from the collection using ISBN
    public void RemoveBook(string ISBNtoRemove)
    {
        if (collection.Contains(ISBNtoRemove))
        {
            collection.Remove(ISBNtoRemove);
            Console.WriteLine($"{ISBNtoRemove} poistettu.");
        }
        else
        {
            Console.WriteLine("Väärä ISBN-numero. Kirjoita numero uudestaan.");     }
    }*/


    //Method for listing books of the collection
    public void ListBooks()
    {
        foreach (Book book in collection)
        {
            Console.WriteLine(book);
        }
    }
}
    
