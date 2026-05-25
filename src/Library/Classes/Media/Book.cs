namespace Library
{
    // Clase que representa un libro
    public class Book: Media
    {
        private string author;
        public string Author
        {
            get {return this.author;} set {this.author = value;}
        }

        //Constructor
        public Book(string name, double calification, string author, List<Tag> tags)
        {
            this.Name = name;
            this.Calification = calification;
            this.Author = author;
            this.Tags = tags;
        }
    }
}