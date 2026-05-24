namespace Library
{
    //Fachada
    public class Bot
    {
        private Biblioteca biblioteca;
        public Biblioteca Biblioteca
        {
            get {return this.biblioteca;}
        }

        //Constructor
        public Bot(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca;
        }

        public void RecommendMovies()
        {
            
        }
        public void RecommendSongs()
        {
            
        }
        public void RecommendBooks()
        {
            
        }


    }
}