using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1_Tereshchuk
{

    class Program
    {


        public class Magazin
        {
            public int Id;

            public string Name = "Undefined";

            public string Periodicity = "Undefined";

            public DateOnly Date = new DateOnly(2023, 1, 1);

            public int Circulation = 0;


            public Magazin(int a, string b, string c, DateOnly d, int e)
            {
                this.Id = a;
                this.Name = b;
                this.Periodicity = c;
                this.Date = d;
                this.Circulation = e;
            }

            public override string ToString()
            {
                return string.Format($"id = {this.Id}; name = {this.Name}; periodicity = {this.Periodicity}; date = {this.Date}; circulation = {this.Circulation}\n");
            }

        }


        public class DataEqualityComparer : IEqualityComparer<Magazin>
        {
            public bool Equals(Magazin x, Magazin y)
            {
                bool Result = false;
                if (x.Id == y.Id && x.Name == y.Name && x.Periodicity == y.Periodicity && x.Date == y.Date && x.Circulation == y.Circulation)
                    Result = true;
                return Result;
            }
            public int GetHashCode(Magazin obj)
            {
                return obj.Id;
            }
        }


        public class Author
        {
            public int Id;

            public string Fullname = "Undefined";

            public string Workplace { get; set; }

            public Author(int a, string b, string c)
            {
                this.Id = a;
                this.Fullname = b;
                this.Workplace = c;
            }


            public override string ToString()
            {
                return string.Format($"Id = {this.Id}; fullname = {this.Fullname}; workplace = {this.Workplace}\n");
            }

            
        }


        public class Article
        {
            public int Id;

            public int AuthorId;

            public int MagazinId;

            public string Name = "Undefined";

            public int SizeInPages;

        public DateOnly Date = new DateOnly(2023, 1, 1);
            

            public Article(int a, int b, int c, string d, int e, DateOnly f)
            {
                this.Id = a;
                this.AuthorId = b;    
                this.MagazinId = c;
                this.Name = d;
                this.SizeInPages = e;
                this.Date = f;
            }

            public override string ToString()
            {
                return string.Format($"Id = {this.Id}; authorId = {this.AuthorId}; magazinId = {this.MagazinId}; name = {this.Name}; sizeInPages = {this.SizeInPages};  date = {this.Date}\n");
            }

        }


        public class Comment
        {
            public int ArticleId;
            public string CommentText;
            public DateTime PostedAt;

            public Comment(int a, string b, DateTime c)
            {
                this.ArticleId = a;
                this.CommentText = b;
                this.PostedAt = c;
            }

            public override string ToString()
            {
                return string.Format($"articleId = {this.ArticleId}; commentText = {this.CommentText};  postedAt = {this.PostedAt}\n");
            }
        }


        static List<Magazin> magazin = new List<Magazin>()
        {
         new Magazin(1, "Cosmopoliten", "Once a week", new DateOnly(2012, 3, 15), 1000 ),
         new Magazin(2, "FourFourTwo", "Once a month", new DateOnly(2003, 2, 1), 25000 ),
         new Magazin(3, "Ukrainian prose", "Once a month", new DateOnly(1999, 8, 23), 16500 ),
         new Magazin(4, "Science", "Twice a month", new DateOnly(2001, 11, 12), 3000 ),
         new Magazin(5, "Word and Time", "Every day", new DateOnly(2015, 7, 29), 152000 ),
        };


        static List<Magazin> magazinWithoutAuthor = new List<Magazin>()
        {
         new Magazin(1, "Ababagalamaga", "Once a week", new DateOnly(2022, 4, 21), 100 ),
         new Magazin(2, "Gwint?", "Once a month", new DateOnly(2023, 4, 1), 250 ),
         new Magazin(3, "The fantastic chronicle of Grigory Chasnyk", null, new DateOnly(2023, 4, 3), 0 ),
         new Magazin(4, "Scientific statistics", null, new DateOnly(2023, 4, 2), 0 ),
        };

        
        static List<Magazin> magazinWithoutEmployees = new List<Magazin>()
        {
         new Magazin(1, "Ababagalamaga", "Once a week", new DateOnly(2022, 4, 21), 100 ),
         new Magazin(2, "Gwint?", "Once a month", new DateOnly(2023, 4, 1), 250 ),
        };
        

        static List<Author> author = new List<Author>()
        {
         new Author(1, "Voronyi Mykola", "Ukrainian prose"),
         new Author(2, "Lukavyi Ivan", "Ukrainian prose"),
         new Author(3, "Vatsko Victor", "FourFourTwo"),
         new Author(4, "David Ostin", "Science"),
         new Author(5, "Isaac ", "Word and Time"),
         new Author(6, "Itachi Uchiha", "Cosmopoliten"),
         new Author(7, "Zinchenko Olexandr", "FourFourTwo"),
        };


        static List<Author> authorWithoutWork = new List<Author>()
        {
         new Author(1, "Gregor Bevz", null),
         new Author(2, "Ivan Poltorak", null),
         new Author(3, "Lina Garmash", null),

        };

        static List<Article> article = new List<Article>()
        {

             new Article(1, 1, 3,  "Memento mori!", 1, new DateOnly(2008, 12, 30) ),
             new Article(2, 7, 2,  "My way", 5, new DateOnly(2023, 1, 12) ),
             new Article(3, 5, 5,  "Ukrainian grammar", 6, new DateOnly(2016, 4, 18) ),
             new Article(4, 4, 4,  "Features of artificial intelligence", 4, new DateOnly(2023, 2, 8) ),
             new Article(5, 7, 2,  "Londons colour", 2, new DateOnly(2023, 3, 27) ),
             new Article(6, 6, 1,  "Sharingan fashion", 12, new DateOnly(2005, 8, 22) ),
             new Article(7, 2, 3,  "Bloody Sivba. History of writing", 11, new DateOnly(2022, 12, 11) ),
             new Article(8, 3, 2,  "Revival of Ukrainian football", 2, new DateOnly(2019, 5, 2) ),
             new Article(9, 4, 4,  "Li-Fi instead Wi-Fi", 6, new DateOnly(2018, 2, 24) ),
        };


        static List<Comment> comment = new List<Comment>()
        {
         new Comment(1, "As a musician, I appreciate the high quality of words, and Memento Mori is a prime example of how poetry can impress deeply and effectively, even in a short period of time.#poetryisnotdead", new DateTime(2012, 4, 2, 10, 35, 50) ),
         new Comment(1, "Voronyi shows that passing time is something we cannot stop and that we must live each day to the fullest. #carpediem #lifelessons", new DateTime(2012, 7, 27, 14, 26, 58) ),
         new Comment(1, "Memento Mori is a piece that reminds us that life is precious and that we should cherish every moment we have. #gratitude #lifeisshort", new DateTime(2013, 1, 12, 8, 29, 12) ),
         new Comment(2, "Siuuu!", new DateTime(2023, 2, 4, 18, 23, 9) ),
         new Comment(4, "it started", new DateTime(2023, 2, 19, 23, 21, 45) ),
         new Comment(4, "Thanks for do my homework. LOL", new DateTime(2023, 2, 26, 20, 34, 36) ),
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

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("0.Article list:");
            Console.ResetColor();
            var q0 = from x in article
                     select x;
            foreach (var x in q0)
                Console.WriteLine(x);



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1.Magazin and their periodicity:");
            Console.ResetColor();
            var q1 = from x in magazin
                     select new{ x.Name, x.Periodicity};
            foreach (var x in q1)
                Console.WriteLine(x);



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 2.Comment to the article №5:");
            Console.ResetColor();
            var q2 = from x in comment
                     where x.ArticleId == 5
                     select x;
            foreach (var x in q2)
                Console.WriteLine(x.CommentText);



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 3.Author, whose name start with I:");
            Console.ResetColor();
            var q3 = from x in author
                     where x.Fullname.StartsWith("I")
                     select x;
            foreach (var x in q3)
                Console.WriteLine(x.Fullname);



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 4.Comments on articles longer than 5 pages published after 2018.01.01:");
            Console.ResetColor();
            var q4 = from x in comment
                     from y in article
                     where y.Id == x.ArticleId && y.SizeInPages > 5 && y.Date > new DateOnly(2018, 1, 1)
                     select x;
            foreach (var x in q4)
                Console.WriteLine(x.CommentText);



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 5.Articles and their authors:");
            Console.ResetColor();
            var q5 = from x in article
                     from y in author
                     where x.AuthorId == y.Id
                     select new { x.Name, y.Fullname };
            foreach (var x in q5)
                Console.WriteLine(x);



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 6.Article longer than 7 pages:");
            Console.ResetColor();
            var q6 = from x in article
                     where x.SizeInPages > 7
                     select x;
            foreach (var x in q6)
                Console.WriteLine(x.Name);



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 7.Magazines in descending order of circulations:");
            Console.ResetColor();
            var q7 = from x in magazin
                     orderby x.Circulation descending
                     select x;
            foreach (var x in q7)
                Console.WriteLine(x.Name);



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 8.The first article of the author whose id is 7:");
            Console.ResetColor();
            var q8 = (from x in article select x).First(x => x.AuthorId == 7);
                Console.WriteLine(q8);



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 9.Employment options for unemployed authors are possible:");
            Console.ResetColor();
            var q9 = from x in authorWithoutWork
                     from y in magazinWithoutAuthor
                     select new { x.Fullname, y.Name  };
            foreach (var x in q9)
                Console.WriteLine(x);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 10.Article and comments to them:");
            Console.ResetColor();
            var q10 = from x in article
                      join y in comment on x.Id equals y.ArticleId into temp
                      select new { v1 = x.Name, d2Group = temp };
            foreach (var x in q10)
            {
                Console.WriteLine("\n" + x.v1);
             foreach (var y in x.d2Group)
                Console.WriteLine(" " + y.CommentText + " : " + y.PostedAt);
            }



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 11.Output specified  workplaces (alphabetically) and authors names (against the alphabet):");
            Console.ResetColor();
            var q11 = author.Where((x) =>
                {
                    return x.Id < 5 && (x.Workplace == "Ukrainian prose" || x.Workplace == "FourFourTwo");
                }).OrderBy(x => x.Workplace).ThenByDescending(x => x.Fullname);
             foreach (var x in q11) 
                Console.WriteLine(x);



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 12.Output magazins with Ids 2 through 4:");
            Console.ResetColor();
            var q12 = magazin.SkipWhile(magazin => (magazin.Id < 2)).TakeWhile(magazin => magazin.Id <= 4);
            foreach (var x in q12)
                Console.WriteLine(x);



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 13.Creation of author-authorWithoutWork pairs based on their Id:");
            Console.ResetColor();
            var q13 = from x in authorWithoutWork
                      join y in author on x.Id equals y.Id into temp
                      from t in temp.DefaultIfEmpty()
                      select new { v1 = x.Fullname, v2 = ((t == null) ? "null" : t.Fullname) };
            foreach (var x in q13)
                Console.WriteLine(x);



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 14.Output the names of articles to which there is a comment:");
            Console.ResetColor();
            var q14 = (from x in comment 
                       from y in article
                       where x.ArticleId == y.Id
                       select  y.Name).Distinct();
            foreach (var x in q14)
                Console.WriteLine(x);



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 15.The number of comments on the article with id 4:");
            Console.ResetColor();
            Console.WriteLine(comment.Count(x => x.ArticleId == 4));



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 16.Creation of the Magazins array:");
            Console.ResetColor();
            var q16 = (from x in magazin select x).ToArray();
            Console.WriteLine(q16.GetType().Name);
            foreach (var x in q16)
                Console.WriteLine(x);



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 17.Output comments by date:");
            Console.ResetColor();
            var q17 = (from x in comment select x).ToLookup(x => x.PostedAt);
            Console.WriteLine(q17.GetType().Name);
            foreach (var x in q17)
            {
                Console.WriteLine(x.Key);
                foreach (var y in x)
                    Console.WriteLine(" " + y.CommentText);
            }



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 18.Total volume of all articles in pages:");
            Console.ResetColor();
            var q18 = article.Aggregate(new Article(0, 0, 0, null, 0, new DateOnly(1, 1, 1)), (total, next) =>
            {
                if (next.SizeInPages > 0) total.SizeInPages += next.SizeInPages;
                return total;
            });
            Console.WriteLine(q18.SizeInPages);



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 19.Magazines with employees but no author:");
            Console.ResetColor();
            foreach (var x in magazinWithoutAuthor.Except(magazinWithoutEmployees, new DataEqualityComparer()))
                Console.WriteLine(x);
        }

    }

}