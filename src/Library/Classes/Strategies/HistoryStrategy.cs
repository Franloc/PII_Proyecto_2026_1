namespace Library
{
    public class HistoryStrategy : IRecommendationStrategy
    {
        public List<IMedia> Recommend(User user, List<IMedia> list_to_recommend)
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
            foreach (IMedia media in list_to_recommend)
            {
                foreach (Tag tag in media.Tags)
                {
                    if (consumedTags.Contains(tag))
                    {
                        recommendations.Add(media);
                    }
                }
            }
            return recommendations;
        }



        
    }
}