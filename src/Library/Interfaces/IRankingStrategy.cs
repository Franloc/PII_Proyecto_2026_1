namespace Library
{
    public interface IRankingStrategy
    {
        List<IMedia> Rank(User user, List<IMedia> media);
    }
}