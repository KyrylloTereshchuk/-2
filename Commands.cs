using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Commands : ICommands
    {
        private readonly IQueries _Querys;
        public Commands(IQueries query)
        {
            _Querys = query;
        }

        public void Exit()
        {
           QueryOutputText(0);
           Environment.Exit(0);
        }



        void QueryOutputText(int a)
        {
            TextToConsole TextToConsole = new TextToConsole();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(TextToConsole.QueryTexts[a]);
            Console.ResetColor();
        }

        public void Command1()
        {
            QueryOutputText(1);

            var allArticles = _Querys.GetArticles();
            foreach (var a in allArticles)
                Console.WriteLine(a);
        }
        public void Command2()
        {
            QueryOutputText(2);

            var magazinsNameAndPeriodicity = _Querys.GetMagazinsNameAndPeriodicity();
            foreach (var m in magazinsNameAndPeriodicity)
                Console.WriteLine(m);
        }
        public void Command3()
        {
            QueryOutputText(3);

            var commentsToArticle5 = _Querys.GetCommentsToArticle(5);
            foreach (var c in commentsToArticle5)
                Console.WriteLine(c);
        }
        public void Command4()
        {
            QueryOutputText(4);

            var authorsStartWithI = _Querys.GetAuthorsStartWith("I");
            foreach (var a in authorsStartWithI)
                Console.WriteLine(a);
        }
        public void Command5()
        {
            QueryOutputText(5);

            var commentsToArticleLonger5Pages = _Querys.GetCommentsToArticleLongerAndOlderThan(5, new DateOnly(2018, 1, 1));
            foreach (var c in commentsToArticleLonger5Pages)
                Console.WriteLine(c);
        }
        public void Command6()
        {
            QueryOutputText(6);

            var collaboration = _Querys.GetCollaboration();
            foreach (var c in collaboration)
                Console.WriteLine(c);
        }
     
        public void Command7()
        {
            QueryOutputText(7);

            var authorsWhereWorkplaceIs = _Querys.GetAuthorsWhereWorkplaceIs("Science");
            foreach (var a in authorsWhereWorkplaceIs)
                Console.WriteLine(a);
        }
        public void Command8()
        {
            QueryOutputText(8);

            Console.WriteLine(_Querys.GetMaxCirculation());
        }
        public void Command9()
        {
            QueryOutputText(9);

            var firstArticleWithAuthorId = _Querys.GetFirstArticleWithAuthorId(7);
            Console.WriteLine(firstArticleWithAuthorId);
        }
        public void Command10()
        {
            QueryOutputText(10);

            //var comments = _Querys.GetCommentsWithUsePredicate(x => x.EndsWith("!"));
            var comments = _Querys.GetCommentsWithUsePredicate(x => x.StartsWith("A"));
            foreach (var c in comments)
                Console.WriteLine(c);
        }
        public void Command11()
        {
            Collections Collections = new Collections();
            QueryOutputText(11);

            var articlesAndCommentToIt = _Querys.GetArticlesAndCommentToThem();
            foreach (var g in articlesAndCommentToIt)
            {
                Console.WriteLine($"{g.ArticleName}:");
                foreach (var comment in g.Comments)
                {
                    Console.WriteLine($"    {comment.CommentText} : {comment.PostedAt}");
                }
            }
        }
        public void Command12()
        {
            QueryOutputText(12);

            var authorByCondition = _Querys.GetAuthorByCondition(5, "Ukrainian prose", "FourFourTwo");
            foreach (var a in authorByCondition)
                Console.WriteLine(a);
        }
        public void Command13()
        {
            QueryOutputText(13);

            var magazinFromTo = _Querys.GetMagazinFromTo(2, 4);
            foreach (var m in magazinFromTo)
                Console.WriteLine(m);
        }
        public void Command14()
        {
            QueryOutputText(14);

            var authorsAndTheirWorkplace = _Querys.GetAuthorsAndTheirWorkplace();
            foreach (var a in authorsAndTheirWorkplace)
                Console.WriteLine(a);
        }
        public void Command15()
        {
            QueryOutputText(15);

            var articlesNameThatHaveComents = _Querys.GetArticlesNameThatHaveComents();
            foreach (var a in articlesNameThatHaveComents)
                Console.WriteLine(a);
        }
        public void Command16()
        {
            QueryOutputText(16);

            Console.WriteLine(_Querys.GetNumberOfCommentsToArticle(4));
        }
        public void Command17()
        {
            QueryOutputText(17);

            var magazinsArray = _Querys.GetMagazinsArray();
            foreach (var m in magazinsArray)
                Console.WriteLine(m);
        }
        public void Command18()
        {
            Collections Collections = new Collections();
            QueryOutputText(18);

            var lookup = _Querys.GetLookup();

            foreach (var group in lookup)
            {
                Console.WriteLine(group.Key);
                foreach (var comment in group)
                {
                    Console.WriteLine("   " + comment);
                }
            }
        }
        public void Command19()
        {
            QueryOutputText(19);

            var totalSize = _Querys.GetTotalSize();          
                Console.WriteLine(totalSize);
        }
        public void Command20()
        {
            Collections Collections = new Collections();
            QueryOutputText(20);

            var magazinWithoutEmployees = _Querys.GetMagazinWithoutAuthors();
            foreach (var m in magazinWithoutEmployees)
                Console.WriteLine(m);
        }
        public void Command21()
        {
            Collections Collections = new Collections();
            QueryOutputText(21);

            var magazinByPeriodicity = _Querys.GetMagazinByPeriodicity("Once a month");
            foreach (var m in magazinByPeriodicity)
                Console.WriteLine(m);
        }
        public void Command22()
        {
            QueryOutputText(22);

            var publications = _Querys.GetPublications();
            foreach (var p in publications)
                Console.WriteLine(p);
        }
       
    }
}
