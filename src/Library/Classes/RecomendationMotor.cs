namespace Library
{
    //Motor de Recomendacion
    public class RecommendationEngine
    {
        private List<IRecommendationStrategy> recommendationStrategies;
        public List<IRecommendationStrategy> RecommendationStrategies
        {
            get {return this.recommendationStrategies;} set{this.recommendationStrategies = value;}
        }
        private List<IFilter> filters;
        public List<IFilter> Filters
        {
            get {return this.filters;} set {this.filters = value;}
        }
        private IRankingStrategy rankingStrategy;
        public IRankingStrategy RankingStrategy
        {
            get {return this.rankingStrategy;} set {this.rankingStrategy = value;}
        }
        private Biblioteca biblioteca;
        public Biblioteca Biblioteca
        {
            get {return this.biblioteca;} set {this.biblioteca = value;}
        }
        public List<IMedia> Recommend(User user)
        {
            List<IMedia> recommendations = new List<IMedia>();
            foreach (IRecommendationStrategy strategy in this.recommendationStrategies)
            {
                recommendations.AddRange(strategy.Recommend(user, biblioteca));
            }
            recommendations = recommendations.Distinct().ToList();
            foreach (IFilter filter in this.filters)
            {
                recommendations = filter.Filter(user, recommendations);
            }
            recommendations = this.rankingStrategy.Rank(user, recommendations);
            return recommendations;
        }
        //Constructor
        public RecommendationEngine(List<IRecommendationStrategy> strategies, List<IFilter> filters, IRankingStrategy ranking, Biblioteca biblioteca)
        {
            this.recommendationStrategies = strategies;
            this.filters = filters;
            this.rankingStrategy = ranking;
            this.biblioteca = biblioteca;
        }
    }
}