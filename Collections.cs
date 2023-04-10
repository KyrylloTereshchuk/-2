using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
    
    {
    static class Collections
    {
       public static List<Magazin> Magazins = new List<Magazin>()
        {
            new Magazin(1, "Cosmopoliten", "Once a week", new DateOnly(2012, 3, 15), 1000 ),
            new Magazin(2, "FourFourTwo", "Once a month", new DateOnly(2003, 2, 1), 25000 ),
            new Magazin(3, "Ukrainian prose", "Once a month", new DateOnly(1999, 8, 23), 16500 ),
            new Magazin(4, "Science", "Twice a month", new DateOnly(2001, 11, 12), 3000 ),
            new Magazin(5, "Word and Time", "Every day", new DateOnly(2015, 7, 29), 152000 ),
        };


        public static List<Magazin> MagazinsWithoutAuthor = new List<Magazin>()
        {
            new Magazin(1, "Ababagalamaga", "Once a week", new DateOnly(2022, 4, 21), 100 ),
            new Magazin(2, "Gwint?", "Once a month", new DateOnly(2023, 4, 1), 250 ),
            new Magazin(3, "The fantastic chronicle of Grigory Chasnyk", null, new DateOnly(2023, 4, 3), 0 ),
            new Magazin(4, "Scientific statistics", null, new DateOnly(2023, 4, 2), 0 ),
        };


        public static List<Magazin> MagazinsWithoutEmployees = new List<Magazin>()
        {
            new Magazin(1, "Ababagalamaga", "Once a week", new DateOnly(2022, 4, 21), 100 ),
            new Magazin(2, "Gwint?", "Once a month", new DateOnly(2023, 4, 1), 250 ),
        };


        public static List<Author> Authors = new List<Author>()
        {
            new Author(1, "Voronyi Mykola", "Ukrainian prose"),
            new Author(2, "Lukavyi Ivan", "Ukrainian prose"),
            new Author(3, "Vatsko Victor", "FourFourTwo"),
            new Author(4, "David Ostin", "Science"),
            new Author(5, "Isaac ", "Word and Time"),
            new Author(6, "Itachi Uchiha", "Cosmopoliten"),
            new Author(7, "Zinchenko Olexandr", "FourFourTwo"),
        };


        public static List<Author> AuthorsWithoutWork = new List<Author>()
        {
            new Author(8, "Gregor Bevz", null),
            new Author(9, "Ivan Poltorak", null),
            new Author(10, "Lina Garmash", null),

        };

        public static List<Article> Articles = new List<Article>()
        {

             new Article(1, Authors[0].Id,  "Memento mori!", 1, new DateOnly(2008, 12, 30) ),
             new Article(2, Authors[6].Id,  "My way", 5, new DateOnly(2023, 1, 12) ),
             new Article(3, Authors[4].Id,  "Ukrainian grammar", 6, new DateOnly(2016, 4, 18) ),
             new Article(4, Authors[3].Id,  "Features of artificial intelligence", 4, new DateOnly(2023, 2, 8) ),
             new Article(5, Authors[6].Id,  "Londons colour", 2, new DateOnly(2023, 3, 27) ),
             new Article(6, Authors[5].Id,  "Sharingan fashion", 12, new DateOnly(2005, 8, 22) ),
             new Article(7, Authors[1].Id,  "Bloody Sivba. History of writing", 11, new DateOnly(2022, 12, 11) ),
             new Article(8, Authors[2].Id,  "Revival of Ukrainian football", 2, new DateOnly(2019, 5, 2) ),
             new Article(9, Authors[3].Id,  "Li-Fi instead Wi-Fi", 6, new DateOnly(2018, 2, 24) ),
        };


        public static List<Comment> Comments = new List<Comment>()
        {
            new Comment(1, "As a musician, I appreciate the high quality of words, and Memento Mori is a prime example of how poetry can impress deeply and effectively, even in a short period of time.#poetryisnotdead", new DateTime(2012, 4, 2, 10, 35, 50) ),
            new Comment(1, "Voronyi shows that passing time is something we cannot stop and that we must live each day to the fullest. #carpediem #lifelessons", new DateTime(2012, 7, 27, 14, 26, 58) ),
            new Comment(1, "Memento Mori is a piece that reminds us that life is precious and that we should cherish every moment we have. #gratitude #lifeisshort", new DateTime(2013, 1, 12, 8, 29, 12) ),
            new Comment(2, "Siuuu!", new DateTime(2023, 2, 4, 18, 23, 9) ),
            new Comment(4, "it started", new DateTime(2023, 2, 19, 23, 21, 45) ),
            new Comment(4, "Wow! Thanks for do my homework. LOL", new DateTime(2023, 2, 26, 20, 34, 36) ),
            new Comment(5, "Will always be red", new DateTime(2023, 3, 28, 14, 17, 32) ),
            new Comment(5, "Only Chealsy!Only blue!!!!!!!", new DateTime(2023, 3, 28, 19, 42, 12) ),
            new Comment(5, "Arsenal - champ", new DateTime(2023, 4, 1, 2, 56, 21) ),
            new Comment(5, "Love u, Zina", new DateTime(2023, 4, 3, 12, 11, 45) ),
            new Comment(6, "SAAAASKEEEE", new DateTime(2005, 9, 1, 21, 24, 11) ),
            new Comment(6, "always in fashion", new DateTime(2005, 12, 17, 7, 45, 12) ),
            new Comment(6, "Why do i have to read this b#llsh#t!?", new DateTime(2008, 2, 24, 17, 23, 53) ),
            new Comment(7, "Wow! Its really great", new DateTime(2022, 12, 31, 10, 23, 41) ),
            new Comment(8, "All ukrainians in England now(((", new DateTime(2019, 6, 12, 11, 4, 13) ),
            new Comment(9, "and what to do at night?)", new DateTime(2018, 4, 29, 14, 21, 43) ),
            new Comment(9, "Maybe it will really change something", new DateTime(2022, 7, 2, 23, 15, 23) ),
        };

        public static List<string > QueryTexts = new List<string>()
        {
            "0.Article list:",
            "1.Magazin and their periodicity:",
            "\n 2.Comment to the article №5:",
            "\n 3.Author, whose name start with I:",
            "\n 4.Comments on articles longer than 5 pages published after 2018.01.01:",
            "\n 5.Output of magazins and their authors:",
            "\n 6.Authors working in Science:",
            "\n 7.Magazines in descending order of circulations:",
            "\n 8.The first article of the author whose id is 7:",
            "\n 9.Comments what started with Wow:",
            "\n 10.Article and comments to them:",
            "\n 11.Output specified  workplaces (alphabetically) and authors names (against the alphabet):",
            "\n 12.Output magazins with Ids 2 through 4:",
            "\n 13.Creation of author-authorWithoutWork pairs based on their Id:",
            "\n 14.Output the names of articles to which there is a comment:",
            "\n 15.The number of comments on the article with id 4:",
            "\n 16.Creation of the Magazins array:",
            "\n 17.Output comments by date:",
            "\n 18.Total volume of all articles in pages:",
            "\n 19.Magazines with employees but no author:",
            "\n 20.Magazines published once a month:",
           
        };

        public static List<Collaborations> Collaborations = new List<Collaborations>()
        {
            new Collaborations( Authors[0].Id, Magazins[2].Id),
            new Collaborations( Authors[1].Id, Magazins[2].Id),
            new Collaborations( Authors[2].Id, Magazins[1].Id),
            new Collaborations( Authors[3].Id, Magazins[3].Id),
            new Collaborations( Authors[4].Id, Magazins[4].Id),
            new Collaborations( Authors[5].Id, Magazins[0].Id),
            new Collaborations( Authors[6].Id, Magazins[1].Id),
            new Collaborations( AuthorsWithoutWork[0].Id, 0),
            new Collaborations( AuthorsWithoutWork[1].Id, 0),
            new Collaborations( AuthorsWithoutWork[2].Id, 0),
        };

        public static List<Publications> Publications = new List<Publications>()
        {
            new Publications( Articles[0].Id, Magazins[2].Id),
            new Publications( Articles[0].Id, Magazins[3].Id),
            new Publications( Articles[0].Id, Magazins[4].Id),
            new Publications( Articles[1].Id, Magazins[1].Id),
            new Publications( Articles[2].Id, Magazins[2].Id),
            new Publications( Articles[2].Id, Magazins[4].Id),
            new Publications( Articles[3].Id, Magazins[3].Id),
            new Publications( Articles[4].Id, Magazins[0].Id),
            new Publications( Articles[4].Id, Magazins[1].Id),
            new Publications( Articles[4].Id, Magazins[4].Id),
            new Publications( Articles[5].Id, Magazins[0].Id),
            new Publications( Articles[6].Id, Magazins[0].Id),
            new Publications( Articles[6].Id, Magazins[2].Id),
            new Publications( Articles[6].Id, Magazins[3].Id),
            new Publications( Articles[6].Id, Magazins[4].Id),
            new Publications( Articles[7].Id, Magazins[0].Id),
            new Publications( Articles[7].Id, Magazins[1].Id),
            new Publications( Articles[7].Id, Magazins[4].Id),
            new Publications( Articles[8].Id, Magazins[3].Id),
        };


    }
}
