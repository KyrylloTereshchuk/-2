using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Collections : ICollections
    {
        public IEnumerable<Magazine> Magazines => new List<Magazine>()
        {
            new Magazine(1, "Cosmopoliten", "Once a week", 1000 ) {Date = new DateOnly(2012, 3, 15) },
            new Magazine(2, "FourFourTwo", "Once a month", 25000 ) { Date = new DateOnly(2003, 2, 1) },
            new Magazine(3, "Ukrainian prose", "Once a month", 16500 ) { Date = new DateOnly(1999, 8, 23) },
            new Magazine(4, "Science", "Twice a month", 3000 ) { Date = new DateOnly(2001, 11, 12) },
            new Magazine(5, "Word and Time", "Every day", 152000 ) { Date = new DateOnly(2015, 7, 29) },
        };

        public IEnumerable<Magazine> MagazinesWithoutAuthor => new List<Magazine>()
        {
            new Magazine(1, "Ababagalamaga", "Once a week", 100 ) { Date = new DateOnly(2022, 4, 21) },
            new Magazine(2, "Gwint?", "Once a month", 250 ) { Date = new DateOnly(2023, 4, 1) },
            new Magazine(3, "The fantastic chronicle of Grigory Chasnyk", "Not specified", 0 ) { Date = new DateOnly(2023, 4, 3) },
            new Magazine(4, "Scientific statistics", "Not specified", 0 ) { Date = new DateOnly(2023, 4, 2) },
        };

        public IEnumerable<Magazine> MagazinesWithoutEmployees => new List<Magazine>()
        {
            new Magazine(1, "Ababagalamaga", "Once a week", 100 ) { Date = new DateOnly(2022, 4, 21)},
            new Magazine(2, "Gwint?", "Once a month", 250 ) { Date = new DateOnly(2023, 4, 1) },
        };

        public IEnumerable<Author> Authors => new List<Author>()
        {
            new Author(1, "Voronyi Mykola") { Workplace = "Ukrainian prose" },
            new Author(2, "Lukavyi Ivan") { Workplace = "Ukrainian prose" },
            new Author(3, "Vatsko Victor") { Workplace = "FourFourTwo" },
            new Author(4, "David Ostin") { Workplace = "Science" },
            new Author(5, "Isaac ") { Workplace = "Word and Time" },
            new Author(6, "Itachi Uchiha") { Workplace = "Cosmopoliten" },
            new Author(7, "Zinchenko Olexandr") { Workplace = "FourFourTwo" },
        };

        public IEnumerable<Author> AuthorsWithoutWork => new List<Author>()
        {
            new Author(8, "Gregor Bevz"),
            new Author(9, "Ivan Poltorak"),
            new Author(10, "Lina Garmash"),
        };

        public IEnumerable<Article> Articles => new List<Article>()
        {

             new Article(1, Authors.ElementAt(0).Id,  "Memento mori!", 1 ) { Date = new DateOnly(2008, 12, 30) },
             new Article(2, Authors.ElementAt(6).Id,  "My way", 5 ) { Date = new DateOnly(2023, 1, 12) },
             new Article(3, Authors.ElementAt(4).Id,  "Ukrainian grammar", 6 ) { Date = new DateOnly(2016, 4, 18) },
             new Article(4, Authors.ElementAt(3).Id,  "Features of artificial intelligence", 4 ) { Date = new DateOnly(2023, 2, 8) },
             new Article(5, Authors.ElementAt(6).Id,  "Londons colour", 2 ) { Date = new DateOnly(2023, 3, 27) },
             new Article(6, Authors.ElementAt(5).Id,  "Sharingan fashion", 12 ) { Date = new DateOnly(2005, 8, 22) },
             new Article(7, Authors.ElementAt(1).Id,  "Bloody Sivba. History of writing", 11 ) { Date = new DateOnly(2022, 12, 11) },
             new Article(8, Authors.ElementAt(2).Id,  "Revival of Ukrainian football", 2 ) { Date = new DateOnly(2019, 5, 2) },
             new Article(9, Authors.ElementAt(3).Id,  "Li-Fi instead Wi-Fi", 6 ) { Date = new DateOnly(2018, 2, 24) },
        };

        public IEnumerable<Comment> Comments => new List<Comment>()
        {
            new Comment(1, "As a musician, I appreciate the high quality of words, and Memento Mori is a prime example of how poetry can impress deeply and effectively, even in a short period of time.#poetryisnotdead" ) { PostedAt = new DateTime(2012, 4, 2, 10, 35, 50) },
            new Comment(1, "Voronyi shows that passing time is something we cannot stop and that we must live each day to the fullest. #carpediem #lifelessons" ) { PostedAt = new DateTime(2012, 7, 27, 14, 26, 58) },
            new Comment(1, "Memento Mori is a piece that reminds us that life is precious and that we should cherish every moment we have. #gratitude #lifeisshort" ) { PostedAt = new DateTime(2013, 1, 12, 8, 29, 12) },
            new Comment(2, "Siuuu!" ) { PostedAt = new DateTime(2023, 2, 4, 18, 23, 9) },
            new Comment(4, "it started" ) { PostedAt = new DateTime(2023, 2, 19, 23, 21, 45) },
            new Comment(4, "Wow! Thanks for do my homework. LOL" ) { PostedAt = new DateTime(2023, 2, 26, 20, 34, 36) },
            new Comment(5, "Will always be red" ) { PostedAt = new DateTime(2023, 3, 28, 14, 17, 32) },
            new Comment(5, "Only Chealsy!Only blue!!!!!!!" ) { PostedAt = new DateTime(2023, 3, 28, 19, 42, 12) },
            new Comment(5, "Arsenal - champ" ) { PostedAt = new DateTime(2023, 4, 1, 2, 56, 21) },
            new Comment(5, "Love u, Zina" ) { PostedAt = new DateTime(2023, 4, 1, 2, 56, 21) },
            new Comment(6, "SAAAASKEEEE" ) { PostedAt = new DateTime(2005, 9, 1, 21, 24, 11) },
            new Comment(6, "always in fashion" ) { PostedAt = new DateTime(2005, 12, 17, 7, 45, 12) },
            new Comment(6, "Why do i have to read this b#llsh#t!?" ) { PostedAt = new DateTime(2008, 2, 24, 17, 23, 53) },
            new Comment(7, "Wow! Its really great" ) { PostedAt = new DateTime(2022, 12, 31, 10, 23, 41) },
            new Comment(8, "All ukrainians in England now(((" ) { PostedAt = new DateTime(2019, 6, 12, 11, 4, 13) },
            new Comment(9, "and what to do at night?)" ) { PostedAt = new DateTime(2018, 4, 29, 14, 21, 43) },
            new Comment(9, "Maybe it will really change something" ) { PostedAt = new DateTime(2022, 7, 2, 23, 15, 23) },
        };

        public IEnumerable<Collaborations> Collaborations => new List<Collaborations>()
         {
             new Collaborations( Authors.ElementAt(0).Id, Magazines.ElementAt(2).Id),
             new Collaborations( Authors.ElementAt(1).Id, Magazines.ElementAt(2).Id),
             new Collaborations( Authors.ElementAt(2).Id, Magazines.ElementAt(1).Id),
             new Collaborations( Authors.ElementAt(3).Id, Magazines.ElementAt(3).Id),
             new Collaborations( Authors.ElementAt(4).Id, Magazines.ElementAt(4).Id),
             new Collaborations( Authors.ElementAt(5).Id, Magazines.ElementAt(0).Id),
             new Collaborations( Authors.ElementAt(6).Id, Magazines.ElementAt(1).Id),
             new Collaborations( AuthorsWithoutWork.ElementAt(0).Id, 0),
             new Collaborations( AuthorsWithoutWork.ElementAt(1).Id, 0),
             new Collaborations( AuthorsWithoutWork.ElementAt(2).Id, 0),
         };

        public IEnumerable<Publications> Publications => new List<Publications>()
         {
             new Publications( Articles.ElementAt(0).Id, Magazines.ElementAt(2).Id),
             new Publications( Articles.ElementAt(0).Id, Magazines.ElementAt(3).Id),
             new Publications( Articles.ElementAt(0).Id, Magazines.ElementAt(4).Id),
             new Publications( Articles.ElementAt(1).Id, Magazines.ElementAt(1).Id),
             new Publications( Articles.ElementAt(2).Id, Magazines.ElementAt(2).Id),
             new Publications( Articles.ElementAt(2).Id, Magazines.ElementAt(4).Id),
             new Publications( Articles.ElementAt(3).Id, Magazines.ElementAt(3).Id),
             new Publications( Articles.ElementAt(4).Id, Magazines.ElementAt(0).Id),
             new Publications( Articles.ElementAt(4).Id, Magazines.ElementAt(1).Id),
             new Publications( Articles.ElementAt(4).Id, Magazines.ElementAt(4).Id),
             new Publications( Articles.ElementAt(5).Id, Magazines.ElementAt(0).Id),
             new Publications( Articles.ElementAt(6).Id, Magazines.ElementAt(0).Id),
             new Publications( Articles.ElementAt(6).Id, Magazines.ElementAt(2).Id),
             new Publications( Articles.ElementAt(6).Id, Magazines.ElementAt(3).Id),
             new Publications( Articles.ElementAt(6).Id, Magazines.ElementAt(4).Id),
             new Publications( Articles.ElementAt(7).Id, Magazines.ElementAt(0).Id),
             new Publications( Articles.ElementAt(7).Id, Magazines.ElementAt(1).Id),
             new Publications( Articles.ElementAt(7).Id, Magazines.ElementAt(4).Id),
             new Publications( Articles.ElementAt(8).Id, Magazines.ElementAt(3).Id),
         };

    }

}
