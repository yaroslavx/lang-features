namespace lang_features;

public class Book
{
    public string Title { get; set; }
    public Author Author { get; set; }
    public Book(string title, Author author) => (Title, Author) = (title, author);
    
    public static bool DoesHaveDiscount(Book book)
    {
        return book switch
        {
            { Author.LastName: "Richter" }
                or { Author.LastName: "Price" } => true,
            _ => false
        };
    }
}

public class Author
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Author(string firstName, string lastName) => (FirstName, LastName) = (firstName, lastName);
}