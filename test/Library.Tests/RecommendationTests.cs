namespace Library.Tests
{
    public class RecommendationTests
    {
        [SetUp]
        public void Setup()
        {
    
        }

        /// <summary>
        /// Test Sobre la biblioteca
        /// </summary>
        [Test]
        public void Reccomend_000000_GoodRecommendation()
        {
            Biblioteca bibliotec = new Biblioteca();

            //Tags
            Tag cienciaFiccionTag = new Tag ("ciencia ficcion");
            Tag accionTag = new Tag ("accion");
            Tag rockTag = new Tag ("rock");
            Tag popTag = new Tag ("pop");
            Tag tangoTag = new Tag ("tango");
            Tag fabulaTag = new Tag ("fabula");
            Tag narrativoTag = new Tag ("narrativo");
            Tag novelaTag = new Tag ("novela");

            //Peliculas
            Movie starWars1 = new Movie("Star Wars A New Hope", 9, new List<Tag>{cienciaFiccionTag, accionTag});
            Movie starWars2 = new Movie("Star Wars The Empire Strickes Back", 10, new List<Tag>{cienciaFiccionTag, accionTag});
            Movie starWars3 = new Movie("Star Wars Return of the Jedi", 9.2, new List<Tag>{cienciaFiccionTag, accionTag});
            bibliotec.Movies.AddRange(new List<Movie> {starWars1, starWars2, starWars3});

            //Canciones
            Song cumparsita = new Song("cumparsita", 8, "juan D'Arienzo", new List<Tag>{tangoTag});
            Song weapon = new Song("weapon", 8.7, "against the current", new List<Tag>{rockTag});
            Song theNights = new Song("the nights", 9.5, "avicci", new List<Tag>{popTag});
            bibliotec.Songs.AddRange(new List<Song> {cumparsita, weapon, theNights});

            //Libros
            Book elPrincipito  = new Book("el principito", 9, "antoine", new List<Tag>{fabulaTag});
            Book divinaComedia = new Book("la divina comedia", 10, "dante alighieri", new List<Tag>{narrativoTag});
            Book quijote = new Book("quijote", 9.2, "miguel de cervantes", new List<Tag>{novelaTag});
            bibliotec.Books.AddRange(new List<Book> {elPrincipito, divinaComedia, quijote});

            Assert.Pass();
        }
    }
}