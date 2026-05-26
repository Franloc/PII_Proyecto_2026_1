using System.Collections.Generic;

namespace Library
{
    // Clase que representa una cancion
    public class Song: Media
    {
        private string artist;
        public string Artist
        {
            get {return this.artist;} set{this.artist = value;}
        }

        //Constructor
        public Song(string name, double calification, string artista, List<Tag> tags)
        {
            this.Name = name;
            this.Calification = calification;
            this.Artist = artista;
            this.Tags = tags;

        }
    }
}