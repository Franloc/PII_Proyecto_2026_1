using System.Collections.Generic;

namespace Library
{
    public class PreferencesStrategy : IRecommendationStrategy
    {
        public List<IMedia> Recommend(User user, Biblioteca biblioteca)
        {
            List<IMedia> recommendations = new List<IMedia>();

            foreach (IMedia media in biblioteca.Media)
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