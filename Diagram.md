classDiagram

class IMedia {
    <<interface>>
    +string Name
    +double Calification
    +List<Tag> Tags
}

class IRecommendationStrategy {
    <<interface>>
    +Recommend(User user, Biblioteca biblioteca) List<IMedia>
}

class IRankingStrategy {
    <<interface>>
    +Rank(User user, List<IMedia> media) List<IMedia>
}

class IFilter {
    <<interface>>
    +Filter(User user, List<IMedia> media) List<IMedia>
}

class Tag {
    -string name
}

class Media {
    <<abstract>>
    -string name
    -double calification
    -List<Tag> tags
}

class Movie{}

class Song {
    -string artist
}

class Book {
    -string author
}

class User {
    -string name
    -List<Tag> preferences
    -UserInteractions interactions
}

class UserInteractions {
    -List<IMedia> likedMedia
    -List<IMedia> disLikedMedia
    -List<IMedia> history
}

class Biblioteca {
    -List<IMedia> media
}

class RecommendationEngine {
    -List<IRecommendationStrategy> recommendationStrategies
    -List<IFilter> filters
    -IRankingStrategy rankingStrategy
    -Biblioteca biblioteca

    +Recommend(User user) List<IMedia>
}

class PreferencesStrategy {
    +Recommend(User user, Biblioteca biblioteca) List<IMedia>
}

class HistoryStrategy {
    +Recommend(User user, Biblioteca biblioteca) List<IMedia>
}

class PreferenceRankingStrategy {
    +Rank(User user, List<IMedia> media) List<IMedia>
}

class HistoryFilter {
    +Filter(User user, List<IMedia> media) List<IMedia>
}

class DislikedFilter {
    +Filter(User user, List<IMedia> media) List<IMedia>
}

class Bot {
    -Biblioteca biblioteca

    +DislikeMedia(User user, IMedia media)
    +LikeMedia(User user, IMedia media)
}

IMedia <|.. Media

Media <|-- Movie
Media <|-- Song
Media <|-- Book

IRecommendationStrategy <|.. PreferencesStrategy
IRecommendationStrategy <|.. HistoryStrategy

IRankingStrategy <|.. PreferenceRankingStrategy

IFilter <|.. HistoryFilter
IFilter <|.. DislikedFilter

User --> UserInteractions
User --> Tag

UserInteractions --> IMedia

Biblioteca --> IMedia

RecommendationEngine --> IRecommendationStrategy
RecommendationEngine --> IFilter
RecommendationEngine --> IRankingStrategy
RecommendationEngine --> Biblioteca

PreferencesStrategy --> Biblioteca
HistoryStrategy --> Biblioteca

Media --> Tag

Bot --> Biblioteca