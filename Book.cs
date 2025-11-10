namespace Olio_harjoitusVIII;

// TASK 1 STEP 1

// class "Book" created
public class Book

{
    // Member variables initialized
    private string name;
    private string author;
    private string isbn;
        
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public string Author
    {
        get
        {
            return author;
        }
        set
        {
            author = value;
        }
    }

    public string ISBN
    {
        get
        {
            return isbn;
        }
        set
        {
            isbn = value;
        }
    }


    // Overloaded contructor
        public Book(string name, string author, string isbn)
    {
        this.name = name;
        this.author = author;
        this.isbn = isbn;
    }
}