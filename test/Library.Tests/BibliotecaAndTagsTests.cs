using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Library.Tests
{
    public class BibliotecaTests
    {
        /// <summary>
        /// Test Sobre la biblioteca, evalua que se creen y organizen correctamente los objetos de dominio y los tags
        /// </summary>
        [Test]
        public void BuildMediaAndTags_AddThemToTheBibliotec_AddedCorrectly()
        {
            Biblioteca bibliotec = new Biblioteca();

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
            bibliotec.Media.AddRange(new List<Movie> {starWars1, starWars2, starWars3});

            Assert.That(bibliotec.Media.OfType<Movie>, Contains.Item(starWars1));
            Assert.That(starWars2.Tags, Contains.Item(accionTag));
            Assert.That(starWars3.Calification, Is.EqualTo(9.2));

            //Canciones
            Song cumparsita = new Song("cumparsita", 8, "juan D'Arienzo", new List<Tag>{tangoTag});
            Song weapon = new Song("weapon", 8.7, "against the current", new List<Tag>{rockTag});
            Song theNights = new Song("the nights", 9.5, "avicci", new List<Tag>{popTag});
            bibliotec.Media.AddRange(new List<Song> {cumparsita, weapon, theNights});

            Assert.That(bibliotec.Media.OfType<Song>, Contains.Item(cumparsita));
            Assert.That(weapon.Tags, Contains.Item(rockTag));
            Assert.That(theNights.Artist, Is.EqualTo("avicci"));

            //Libros
            Book elPrincipito  = new Book("el principito", 9, "antoine", new List<Tag>{fabulaTag});
            Book divinaComedia = new Book("la divina comedia", 10, "dante alighieri", new List<Tag>{narrativoTag});
            Book quijote = new Book("quijote", 9.2, "miguel de cervantes", new List<Tag>{novelaTag});
            bibliotec.Media.AddRange(new List<Book> {elPrincipito, divinaComedia, quijote});

            Assert.That(bibliotec.Media.OfType<Book>, Contains.Item(elPrincipito));
            Assert.That(divinaComedia.Tags, Contains.Item(narrativoTag));
            Assert.That(quijote.Author, Is.EqualTo("miguel de cervantes"));

            Assert.Pass();
        }
    }
}