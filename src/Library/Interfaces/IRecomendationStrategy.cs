namespace Library
{
    public interface IRecommendationStrategy // Interfaz de las estrategias de recomendacion
    {
        List<IMedia> Recommend(User user, List<IMedia> media);
    }
}