using System.Collections.Generic;

namespace Library
{
    public class HistoryStrategy : IRecommendationStrategy
    { // Esta estrategia de recomendación genera una lista de recomendaciones basada en el historial del usuario (con media similar a la consumida por el usuario)
        public List<IMedia> Recommend(User user, Biblioteca biblioteca) // Recibe la biblioteca y el usuario a recomendar
        {
            List<IMedia> recommendations = new List<IMedia>();
            List<Tag> consumedTags = new List<Tag>();

            foreach (IMedia media in user.Interactions.History) // Recorro la media consumida por el usuario
            {
                foreach (Tag tag in media.Tags) // Recorro los tags en cada media y los agrego a la lista consumedTags
                {
                    if (!consumedTags.Contains(tag)) // Protección ante duplicados
                    {
                        consumedTags.Add(tag);
                    }
                }
            }
            foreach (IMedia media in biblioteca.Media) // Recorro toda la biblioteca
            {
                foreach (Tag tag in media.Tags) // Recorro cada media en la biblioteca
                {
                    // Agrego la media que tenga tags en común con los tags consumidos por el usuario
                    if (consumedTags.Contains(tag) && !recommendations.Contains(media)) // Además de protección ante duplicados
                    {
                        recommendations.Add(media);
                    }
                }
            }
            return recommendations;
        }
    }
}