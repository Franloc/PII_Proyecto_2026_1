namespace Library
{
    public class Movie: Media
    {
        //Constructor
        public Movie(string name, double calification, List<Tag> tags)
        {
            this.Name = name;
            this.Calification = calification;
            this.Tags = tags;
        }
    }
}