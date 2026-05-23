
//Clase que representa la biblioteca de contenido disponible
namespace Library
{
    public class Biblioteca
    {
        //Listas de contenido(Media)
        private List<Pelicula> peliculas;
        public List<Pelicula> Peliculas
        {
            get{return this.peliculas;} set{this.peliculas = value;}
        }


        //Constructor
        public Biblioteca(List<Pelicula> pelis)
        {
            this.peliculas = new List<Pelicula>(pelis);
        }
    }
}