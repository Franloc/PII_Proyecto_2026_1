namespace Library
{
    public interface IFilter
    {
        List<IMedia> Filter(User user, List<IMedia> media);
    }
}