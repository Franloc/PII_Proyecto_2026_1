namespace Library.Tests
{
    public class BibliotecaTests
    {
        [SetUp]
        public void Setup()
        {
            Tag CienciaFiccionTag = new Tag ("Ciencia Ficcion");
            Tag AccionTag = new Tag ("Accion");
            Movie StarWars1 = new Movie("Star Wars A New Hope", 9, new List<Tag>{CienciaFiccionTag});
            Movie StarWars2 = new Movie("Star Wars The Empire Strickes Back", 10, new List<Tag>{CienciaFiccionTag});
            Movie StarWars3 = new Movie("Star Wars Return of the Jedi", 9.2, new List<Tag>{CienciaFiccionTag});
            Biblioteca bibliotec = new Biblioteca();
            bibliotec.Movies.AddRange(new List<Movie> {StarWars1, StarWars2, StarWars3});
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}