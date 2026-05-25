namespace Library
{
    public class Book: Media
    {
        private string author;
        public string Author
        {
            get; set;
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