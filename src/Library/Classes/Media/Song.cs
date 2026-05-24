namespace Library
{
    public class Song: Media
    {
        //Constructor
        public Song(string name, double calification, List<Tag> tags)
        {
            this.Name = name;
            this.Calification = calification;
            this.Tags = tags;
        }
    }
}