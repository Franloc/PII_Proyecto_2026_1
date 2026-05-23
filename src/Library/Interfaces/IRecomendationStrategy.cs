namespace Library
{
    public interface IRecommendationStrategy
    {
        List<IMedia> Recommend(User user, List<IMedia> media);
    }
}