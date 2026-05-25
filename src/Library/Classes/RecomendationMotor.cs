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

        //Constructor
        public RecommendationEngine(List<IRecommendationStrategy> estrategias)
        {
            this.recommendationStrategies = estrategias;
        }
    }
}