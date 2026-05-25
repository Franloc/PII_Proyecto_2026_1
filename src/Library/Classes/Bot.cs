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

        //No puede haber un objeto en dislike y like al mismo tiempo
        public void DislikeMedia(User user, IMedia media)
        {
            if (user.Interactions.LikedMedia.Contains(media))
            {
                user.Interactions.LikedMedia.Remove(media);
            }
            user.Interactions.DisLikedMedia.Add(media);
        }
        public void LikeMedia(User user, IMedia media)
        {
            if (user.Interactions.DisLikedMedia.Contains(media))
            {
                user.Interactions.DisLikedMedia.Remove(media);
            }
            user.Interactions.LikedMedia.Add(media);
        }
    }
}