using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Olio_harjoitusVIII;


// TASK 1 STEP 2

// parent class "Library"
public class Library

{

    //Empty list for library books
    List<string> collection = new List<string>();


    // Method for adding books to the collection
    public void AddBook(string name, string author, string isbn)
    {
        // create new instance for book
        Library book = new Book(name, author, isbn);
        collection.Add(book.ToString());
        Console.WriteLine($"{name} lisätty.");
        Console.WriteLine();
    }


    // Method for removing a book from the collection using ISBN
    public void RemoveBook(string ISBNtoRemove)
    {
        if (collection.Contains(ISBNtoRemove))
        {
            collection.Remove(ISBNtoRemove);
            Console.WriteLine($"{ISBNtoRemove} poistettu.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Väärä ISBN-numero. Kirjoita numero uudestaan.");
            Console.WriteLine();
        }
    }


    //Method for listing books of the collection
    public void ListBooks()
    {
        foreach (string book in collection)
        {
            Console.WriteLine(book);
        }
    }
}
    
