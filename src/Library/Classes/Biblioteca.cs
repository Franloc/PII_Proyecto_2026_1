
//Clase que representa la biblioteca de contenido disponible
namespace Library
{
    public class Biblioteca
    {
        //Lista de contenido(Media)
        private List<IMedia> media;
        public List<IMedia> Media
        {
            get {return this.media;} set {this.media = value;}
        }

        //Constructor
        public Biblioteca()
        {
            this.media = new List<IMedia>();
        }
    }
}