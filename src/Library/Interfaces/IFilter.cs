namespace Library
{
    public interface Ifilter
    {
        List<IMedia> Filter(User user, List<IMedia> media);
    }
}