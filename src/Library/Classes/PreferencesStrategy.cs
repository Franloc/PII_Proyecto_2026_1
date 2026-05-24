namespace Library
{
    public class PreferencesStrategy : IRecommendationStrategy
    {
        public List<IMedia> Recommend(User user, List<IMedia> list_to_recommend)
        {
            List<IMedia> recommendations = new List<IMedia>();

            foreach (IMedia media in list_to_recommend)
            {
                foreach (Tag preference in user.Preferences)
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