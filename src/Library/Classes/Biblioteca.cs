
//Clase que representa la biblioteca de contenido disponible
namespace Library
{
    public class Biblioteca
    {
        //Listas de contenido(Media)
        private List<Movie> movies;
        public List<Movie> Movies
        {
            get{return this.movies;} set{this.movies = value;}
        }
        private List<Song> songs;
        public List<Song> Songs
        {
            get{return this.songs;} set{this.songs = value;}
        }
        private List<Book> books;
        public List<Book> Books
        {
            get{return this.books;} set{this.books = value;}
        }


        //Constructor
        public Biblioteca()
        {
            //this.movies = new List<Movie>(pelis);
            //this.songs = new List<Song>(canciones);
            //this.books = new List<Book>(libros);
        }
    }
}