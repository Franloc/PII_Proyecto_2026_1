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
        public void DislikeMedia(User user, IMedia media)
        {
            //Falta mejorar proceso
            user.Interactions.DisLikedMedia.Add(media);
        }
        public void LikeMedia(User user, IMedia media)
        {
            //Falta mejorar proceso
            user.Interactions.LikedMedia.Add(media);
        }
    }
}