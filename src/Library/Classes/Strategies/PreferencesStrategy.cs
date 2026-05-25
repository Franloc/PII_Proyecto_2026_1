namespace Library
{
    public class PreferencesStrategy : IRecommendationStrategy
    { // Estrategia de recomendación basada en las preferencias del usuario
        public List<IMedia> Recommend(User user, Biblioteca biblioteca)
        {
            List<IMedia> recommendations = new List<IMedia>();

            foreach (IMedia media in biblioteca.Media) // Recorre la biblioteca
            {
                foreach (Tag preference in user.Preferences) // Recorre los tags en las preferencias de usuario y agrega la media que tenga tags en común con las preferencias de usuario
                {
                    if (media.Tags.Contains(preference) && !recommendations.Contains(media))
                    {
                        recommendations.Add(media);
                    }
                }
            }
            return recommendations;
        }
    }
}