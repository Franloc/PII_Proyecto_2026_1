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
        private Biblioteca biblioteca; // El motor tiene la biblioteca porque es el que recomienda al usuario en base a toda la media disponible, aplicando la guía expert
        public Biblioteca Biblioteca
        {
            get {return this.biblioteca;} set {this.biblioteca = value;}
        }
        public List<IMedia> Recommend(User user, Type tipo) // Aplica estrategia de recomendación, filtros y ranking para recomendar al usuario una lista de media
        {
            List<IMedia> recommendations = new List<IMedia>();
            foreach (IRecommendationStrategy strategy in this.recommendationStrategies) // Le recomienda al usuario usando todas las estrategias de recomendación en la lista de estrategias
            {
                recommendations.AddRange(strategy.Recommend(user, biblioteca));
            }
            recommendations = recommendations.Distinct().ToList(); // Elimina duplicados de la lista obtenida
            foreach (IFilter filter in this.filters) // Aplica los filtros en la lista de filtros
            {
                recommendations = filter.Filter(user, recommendations, tipo);
            }
            recommendations = this.rankingStrategy.Rank(user, recommendations); // Ordena la lista según el ranking
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