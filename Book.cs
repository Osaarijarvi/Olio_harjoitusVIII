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

    // Override ToString() returns a readable representation of the book.
    public override string ToString()
    {
        //return $"{name} — {author} (ISBN: {isbn})";
        return $"{name ?? "<unknown book name>"} — {author ?? "<unknown author name>"} — ISBN: {isbn ?? "<unknown isbn number>"}";
    }
}