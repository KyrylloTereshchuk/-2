using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{

    class Program
    {
  

        static void Main()
        {

             bool exit = false;
            while (!exit)
            {
                Console.Write("\n Enter query number (0-21): ");
                string input = Console.ReadLine();
              
                int queryNumber;
                if (int.TryParse(input, out queryNumber))
                {
                    RunQuery(queryNumber);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Press any key to continue or esc to exit.");
                Console.ResetColor();

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" _Good Bye!");
                    exit = true; 
                }
            }


        }

        static void QueryOutputText(int a)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Collections.QueryTexts[a]);
            Console.ResetColor();
        }


        static void RunQuery(int queryNumber)
        {
            switch (queryNumber)
            {
                case 0:
                    QueryOutputText(0);
                    var q0 = from x in Collections.Articles
                             select x;
                        foreach (var x in q0)
                            Console.WriteLine(x);
                    break;

                case 1:
                    QueryOutputText(1);
                    var q1 = from x in Collections.Magazins
                             select new { x.Name, x.Periodicity };
                        foreach (var x in q1)
                            Console.WriteLine(x);
                    break;

                case 2:
                    QueryOutputText(2);
                    var q2 = from x in Collections.Comments
                             where x.ArticleId == 5
                             select x;
                        foreach (var x in q2)
                            Console.WriteLine(x.CommentText);
                    break;

                case 3:
                    QueryOutputText(3);
                    var q3 = from x in Collections.Authors
                             where x.FullName.StartsWith("I")
                             select x;
                        foreach (var x in q3)
                            Console.WriteLine(x.FullName);
                    break;

                  /*var q3 = from x in Collections.Authors.AuthorStartsWith("I")
                          select x;
                        foreach (var x in q3)
                            Console.WriteLine(x.FullName);
                    break;*/

                case 4:
                    QueryOutputText(4);
                    var q4 = from x in Collections.Comments
                             from y in Collections.Articles
                             where (y.Id == x.ArticleId) && 
                             (y.SizeInPages > 5) && 
                             (y.Date > new DateOnly(2018, 1, 1) )
                             select x;
                        foreach (var x in q4)
                            Console.WriteLine(x.CommentText);
                    break;

                case 5:
                    QueryOutputText(5);
                    var q5 = from x in Collections.Magazins
                             from y in Collections.Authors
                             from z in Collections.Collaborations
                             where (z.AuthorId == y.Id) && 
                             (z.MagazinId == x.Id)
                             orderby x.Name
                             select new { x.Name, y.FullName };
                        foreach (var z in q5)
                            Console.WriteLine(z);
                    break;

                case 6:
                    QueryOutputText(21);
                    var q6 = from x in Collections.Authors.WhereWorkplace("Science")
                              select x;
                    foreach (var x in q6)
                        Console.WriteLine(x);
                    break;

                case 7:
                    QueryOutputText(7);
                    var q7 = from x in Collections.Magazins
                             orderby x.Circulation descending
                             select x;
                        foreach (var x in q7)
                            Console.WriteLine(x.Name);
                    break;

                case 8:
                    QueryOutputText(8);
                    var q8 = (from x in Collections.Articles select x).First(x => x.AuthorId == 7);
                        Console.WriteLine(q8);
                    break;

                case 9:
                    QueryOutputText(9);
                    var q9 = from x in Collections.Comments.CommentStartsWith("Wow")
                              select x;
                    foreach (var x in q9)
                        Console.WriteLine(x);
                    break;

                case 10:
                    QueryOutputText(10);
                    var q10 = from x in Collections.Articles
                              join y in Collections.Comments 
                              on x.Id equals y.ArticleId into temp
                              select new { v1 = x.Name, d2Group = temp };
                    foreach (var x in q10)
                    {
                        Console.WriteLine("\n" + x.v1);
                            foreach (var y in x.d2Group)
                                Console.WriteLine(" " + y.CommentText + " : " + y.PostedAt);
                    }
                    break;

                case 11:
                    QueryOutputText(11);
                    var q11 = Collections.Authors.Where((x) =>
                        {
                            return (x.Id < 5) && ((x.Workplace == "Ukrainian prose") ||
                                (x.Workplace == "FourFourTwo"));
                        }).OrderBy(x => x.Workplace).ThenByDescending(x => x.FullName);
                        foreach (var x in q11)
                            Console.WriteLine(x);
                    break;

                case 12:
                    QueryOutputText(12);
                    var q12 = Collections.Magazins.SkipWhile(magazin => (magazin.Id < 2))
                        .TakeWhile(magazin => magazin.Id <= 4);
                        foreach (var x in q12)
                            Console.WriteLine(x);
                    break;

                case 13:
                    var AllAuthors = Collections.Authors.Concat(Collections.AuthorsWithoutWork);

                    QueryOutputText(13);
                    var q13 = from x in AllAuthors
                              join y in Collections.Magazins 
                              on x.Workplace equals y.Name into temp
                              from t in temp.DefaultIfEmpty()
                              select new { v1 = x.FullName, v2 = ((t == null) ? "null" : t.Name) };
                        foreach (var x in q13)
                            Console.WriteLine(x);
                    break;

                case 14:
                    QueryOutputText(14);
                    var q14 = (from x in Collections.Comments
                               from y in Collections.Articles
                               where x.ArticleId == y.Id
                               select y.Name).Distinct();
                        foreach (var x in q14)
                            Console.WriteLine(x);
                    break;

                case 15:
                    QueryOutputText(15);
                    Console.WriteLine(Collections.Comments.Count(x => x.ArticleId == 4));
                    break;

                case 16:
                    QueryOutputText(16);
                    var q16 = (from x in Collections.Magazins select x).ToArray();
                    Console.WriteLine(q16.GetType().Name);
                        foreach (var x in q16)
                            Console.WriteLine(x);
                    break;

                case 17:
                    QueryOutputText(17);
                    var q17 = (from x in Collections.Comments select x).ToLookup(x => x.PostedAt);
                    Console.WriteLine(q17.GetType().Name);
                    foreach (var x in q17)
                    {
                        Console.WriteLine(x.Key);
                            foreach (var y in x)
                                Console.WriteLine(" " + y.CommentText);
                    }
                    break;

                case 18:
                    QueryOutputText(18);
                    var q18 = Collections.Articles
                        .Aggregate(new Article(0, 0, null, 0, new DateOnly(1, 1, 1)), (total, next) =>
                        {
                             total.SizeInPages += next.SizeInPages;
                                 return total;
                        });
                    Console.WriteLine(q18.SizeInPages);
                    break;

                case 19:
                    QueryOutputText(19);
                    foreach (var x in Collections.MagazinsWithoutAuthor
                        .Except(Collections.MagazinsWithoutEmployees, new DataEqualityComparer()))
                        Console.WriteLine(x);
                    break;

                case 20:
                    QueryOutputText(20);
                    var MagazinsPeriodicity = Collections.Magazins.GroupBy(p => p.Periodicity);
                    foreach (var group in MagazinsPeriodicity)
                    {
                        if (group.Key == "Once a month")
                        {
                            foreach (var magazin in group)
                            {
                                Console.WriteLine(magazin.Name);
                            }
                        }
                    }
                    break;
 
                case 21:
                    QueryOutputText(21);
                    var q21 = from x in Collections.Magazins
                             from y in Collections.Articles
                             from z in Collections.Publications
                             where (z.ArticleId == y.Id) &&
                             (z.MagazinId == x.Id)
                             orderby y.Name 
                             select new { Article = y.Name, Magazin = x.Name };
                    foreach (var z in q21)
                        Console.WriteLine(z);
                    break;

                default:
                    Console.WriteLine("Invalid query number!");
                    break;
            }
        }

    }

}
