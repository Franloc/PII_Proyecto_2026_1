namespace Library
{
    public class HistoryStrategy : IRecommendationStrategy
    {
        public List<IMedia> Recommend(User user, Biblioteca biblioteca)
        {
            List<IMedia> recommendations = new List<IMedia>();
            List<Tag> consumedTags = new List<Tag>();

            foreach (IMedia media in user.Interactions.History)
            {
                foreach (Tag tag in media.Tags)
                {
                    if (!consumedTags.Contains(tag))
                    {
                        consumedTags.Add(tag);
                    }
                }
            }
            foreach (IMedia media in biblioteca.Media)
            {
                foreach (Tag tag in media.Tags)
                {
                    if (consumedTags.Contains(tag) && !recommendations.Contains(media))
                    {
                        recommendations.Add(media);
                    }
                }
            }
            return recommendations;
        }
    }
}