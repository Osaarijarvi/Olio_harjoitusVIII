using System.Collections.ObjectModel;

namespace Olio_harjoitusVIII;

class Program
{
    static void Main(string[] args)
    {
        // TASK 1 STEP 3

        // isRunning initialized
        bool isRunning = true;

        // create new instance for library
        Library collection = new Library();


        while (isRunning)
        {
            // User is asked to choose a function.
            Console.WriteLine();
            Console.WriteLine("Valitse mitä haluat tehdä:");
            Console.WriteLine("a) Lisää kirja kirjastoon.");
            Console.WriteLine("b) Poista kirja kirjastosta.");
            Console.WriteLine("c) Listaa kirjaston kirjat.");
            Console.WriteLine("d) Lopeta ohjelma.");

            // Make input case-insensitive and trim whitespace
            string input = Console.ReadLine()?.Trim().ToLower();
            Console.WriteLine($"DEBUG: menu input = '{input}'");

            switch (input)
            {
                // a) adds a book to the library.
                case "a":

                    Console.WriteLine("Anna kirjan nimi:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Anna kirjan kirjailijan nimi:");
                    string author = Console.ReadLine();
                    Console.WriteLine("Anna kirjan ISBN-numero:");
                    string isbn = Console.ReadLine();

                    Book book = new Book(name, author, isbn);

                    // call for Addbook()
                    collection.AddBook(book);
                    break;

                // b) removes a book to the library.
                case "b":
                    Console.WriteLine("Anna poistettavan kirjan ISBN:");
                    string ISBNtoRemove = Console.ReadLine()?.Trim();
                    Console.WriteLine($"DEBUG: input ISBN to remove = '{ISBNtoRemove}'");
                    collection.RemoveBook(ISBNtoRemove);
                    break;

                //c) lists all the books in the library collection.
                case "c":
                    Console.WriteLine("Kirjaston kirjat listana: ");
                    collection.ListBooks();
                    break;

                // d) stops the programme
                case "d":
                    isRunning = false;
                    break;
                
                default:
                    Console.WriteLine("Tuntematon valinta. Kirjoita a, b, c tai d.");
                    break;
            }
        }
    }
}
