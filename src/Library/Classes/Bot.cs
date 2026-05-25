namespace Library
{
    // Fachada
    public class Bot
    {
        private RecommendationEngine recommendationEngine;
        public RecommendationEngine RecommendationEngine
        {
            get {return this.recommendationEngine;}
        }
        private Biblioteca biblioteca;
        public Biblioteca Biblioteca
        {
            get {return this.biblioteca;}
        }

        //Constructor
        public Bot(Biblioteca biblioteca, RecommendationEngine motor)
        {
            this.biblioteca = biblioteca;
            this.recommendationEngine = motor;
        }

        public void Recommend(User user, Type tipo)
        {
            List<IMedia> Recommendations = new List<IMedia>();
            Recommendations = RecommendationEngine.Recommend(user, tipo);
            //Para proxima entrega hacer clase que se encargue de mostrar las recomendaciones
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