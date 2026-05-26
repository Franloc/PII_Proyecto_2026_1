using System.Collections.Generic;

namespace Library
{
    public interface IRecommendationStrategy // Interfaz de las estrategias de recomendacion
    {
        List<IMedia> Recommend(User user, Biblioteca biblioteca);
    }
}