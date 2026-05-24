namespace Library
{
    public class Book: Media
    {
        //Constructor
        public Book(string name, double calification, List<Tag> tags)
        {
            this.Name = name;
            this.Calification = calification;
            this.Tags = tags;
        }
    }
}