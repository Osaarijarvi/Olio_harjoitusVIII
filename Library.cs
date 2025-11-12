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
        collection.Add(book);
        Console.WriteLine($"{book.Name} lisätty.");
        Console.WriteLine($"Kirjaston kokoelmassa on nyt {collection.Count} kirja(a).");
    }


    // Method for removing a book from the collection using ISBN
    public void RemoveBook(string ISBNtoRemove)
    {
        Console.WriteLine($"DEBUG: RemoveBook called with '{ISBNtoRemove}'");
        
        if (string.IsNullOrWhiteSpace(ISBNtoRemove))
        {
            Console.WriteLine("Anna kelvollinen ISBN.");
            return;
        }

        // Normalize input: trim and remove common separators for comparison
        string normalize(string s) => s?.Trim().Replace("-", "").Replace(" ", "");

        string target = normalize(ISBNtoRemove);

        // Print stored ISBNs for debugging
        Console.WriteLine("DEBUG: Stored ISBNs:");
        foreach (var b in collection)
        {
            Console.WriteLine($" - '{b.ISBN}' (normalized: '{normalize(b.ISBN)}')");
        }

        // Find the book with matching ISBN
        Book book = collection.FirstOrDefault(b => b.ISBN == ISBNtoRemove);

        if (book != null)
        {
            collection.Remove(book);
            Console.WriteLine($"{book.Name} (ISBN: {book.ISBN}) poistettu.");
            Console.WriteLine($"DEBUG: collection count = {collection.Count}");
        }
        else
        {
            Console.WriteLine("Väärä ISBN-numero. Kirjoita numero uudestaan.");
        }
    }

    // Method for listing books of the collection
    public void ListBooks()
    {
        if (collection.Count == 0)
        {
            Console.WriteLine("Kokoelmassa ei ole kirjoja.");
        }
        else
            foreach (Book book in collection)
            {
                Console.WriteLine(book);
            }
    }
}
    
