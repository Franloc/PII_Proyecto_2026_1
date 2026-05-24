
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


        //Constructor
        public Biblioteca(List<Movie> pelis)
        {
            this.movies = new List<Movie>(pelis);
        }
    }
}