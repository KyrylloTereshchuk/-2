using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Queries : IQueries
    {

        public IEnumerable<Article> GetArticles()
        {
            Collections Collections = new Collections();
            return from x in Collections.Articles
                  select x;
        }

        public IEnumerable<HelpMagazinesNameAndPeriodicity> GetMagazinsNameAndPeriodicity()
        {
            Collections Collections = new Collections();
            return from x in Collections.Magazines
                   select new HelpMagazinesNameAndPeriodicity( x.Name, x.Periodicity );
        }

        public IEnumerable<Comment> GetCommentsToArticle( int ArticleNumber)
        {
            Collections Collections = new Collections();
            var query = from x in Collections.Comments
                     where x.ArticleId == ArticleNumber
                        select x;
            return query;
        }
        // GetAuthorsStartWith without using the extension method
        public IEnumerable<string> GetAuthorsStartWith(string BegginingOfName)
        {
            Collections Collections = new Collections();
            var query = from x in Collections.Authors
                        where x.FullName.StartsWith(BegginingOfName)
                        select x.FullName;
            return query;
        }
        // GetAuthorsStartWith using the extension method
        /*  public IEnumerable<string> GetAuthorsStartWith(string BegginingOfName)
          {
          Collections Collections = new Collections();
               var query = from x in Collections.Authors.AuthorStartsWith("I")
                        select x.FullName;
                   return query;
          }*/

        public IEnumerable<Comment> GetCommentsToArticleLongerAndOlderThan( int MinSize, DateOnly MinDate)
        {
            Collections Collections = new Collections();
            var query = from x in Collections.Comments
                        from y in Collections.Articles
                        where (y.Id == x.ArticleId) &&
                        (y.SizeInPages > MinSize) &&
                        (y.Date > MinDate)
                        select x;
            return query;
        }

        public IEnumerable<HelpCollaboration> GetCollaboration()
        {
            Collections Collections = new Collections();
            var query = from x in Collections.Magazines
                     from y in Collections.Authors
                     from z in Collections.Collaborations
                     where (z.AuthorId == y.Id) &&
                     (z.MagazineId == x.Id)
                     select new HelpCollaboration ( x.Name, y.FullName );
            return query;
        }

        public IEnumerable<Author> GetAuthorsWhereWorkplaceIs(string Workplace)
        {
            Collections Collections = new Collections();
            var query = from x in Collections.Authors.WhereWorkplace(Workplace)
                        select x;
            return query;
        }

        public int GetMaxCirculation()
        {
            Collections Collections = new Collections();
            return Collections.Magazines.Max(b => b.Circulation);
        }
        public Article GetFirstArticleWithAuthorId(int AuthorId)
        {
            Collections Collections = new Collections();
            var query = (from x in Collections.Articles select x).First(x => x.AuthorId == AuthorId);
            return query;
        }

        public IEnumerable<Comment> GetCommentsWithUsePredicate(Func<string, bool> startOrEnd)
        {
            Collections Collections = new Collections();
            var query = from x in Collections.Comments.CommentStartsOrEndsWith(startOrEnd)
                        select x;
            return query;
        }

        public IEnumerable<HelpArticlesAndCommentToIt> GetArticlesAndCommentToThem()
        {
          Collections Collections = new Collections();
            var query =  Collections.Articles.GroupJoin(Collections.Comments, g => g.Id, b => b.ArticleId, (b, g) =>
              new HelpArticlesAndCommentToIt
              {
                  ArticleName = b.Name,
                  Comments = g
              }
              );
            return query;
        }

        public IEnumerable<Author> GetAuthorByCondition( int authorId, string Workplace1, string Workplace2)
        {
            Collections Collections = new Collections();
            var query = Collections.Authors.Where((x) =>
            {
                return (x.Id < authorId) && ((x.Workplace == Workplace1) ||
                    (x.Workplace == Workplace2));
            }).OrderBy(x => x.Workplace).ThenByDescending(x => x.FullName);
            return query;
        }

        public IEnumerable<Magazine> GetMagazinFromTo( int MinId, int MaxId)
        {
            Collections Collections = new Collections();
            var query = Collections.Magazines.SkipWhile(magazin => (magazin.Id < MinId))
                        .TakeWhile(magazin => magazin.Id <= MaxId);
            return query;
        }

        public IEnumerable<HelpAuthorsAndTheirWorkplace> GetAuthorsAndTheirWorkplace()
        {
            Collections Collections = new Collections();
            var AllAuthors = Collections.Authors.Concat(Collections.AuthorsWithoutWork);

            
            var query = from x in AllAuthors
                      join y in Collections.Magazines
                      on x.Workplace equals y.Name into temp
                      from t in temp.DefaultIfEmpty()
                      select new HelpAuthorsAndTheirWorkplace (  x.FullName,  ((t == null) ? "not employed" : t.Name) );
            return query;
        }

        public IEnumerable<string> GetArticlesNameThatHaveComents()
        {
            Collections Collections = new Collections();
            var query = (from x in Collections.Comments
                         from y in Collections.Articles
                         where x.ArticleId == y.Id
                         select y.Name).Distinct();
            return query;
        }

        public int GetNumberOfCommentsToArticle(int ArticleId)
        {
            Collections Collections = new Collections();
            var query = Collections.Comments.Count(x => x.ArticleId == ArticleId);
            return query;
        }

        public Magazine [] GetMagazinsArray()
        {
            Collections Collections = new Collections();
            var query = (from x in Collections.Magazines select x).ToArray();
            return query;
        }

        public ILookup<DateTime, string> GetLookup()
        {
            Collections collections = new Collections();
            var query = (from x in collections.Comments
                                select x).ToLookup(x => x.PostedAt, x => x.CommentText);
            return (ILookup<DateTime, string>)query;
        }
        public int GetTotalSize()
        {
            Collections Collections = new Collections();
            var query = Collections.Articles
                        .Aggregate(new Article(0), (total, current) =>
                        {
                            total.SizeInPages += current.SizeInPages;
                            return total;
                        });
            return query.SizeInPages;
        }

        public IEnumerable<Magazine> GetMagazinWithoutAuthors()
        {
            Collections Collections = new Collections();

            foreach (var x in Collections.MagazinesWithoutAuthor
                .Except(Collections.MagazinesWithoutEmployees, new IEqualityComparer()))
                yield return x;
        }

        public List<string> GetMagazinByPeriodicity(string periodicity)
        {
            Collections Collections = new Collections();
            List<string> magazinsName = new List<string>();

            var query = Collections.Magazines.GroupBy(p => p.Periodicity);
            foreach (var group in query)
            {
                if (group.Key == periodicity)
                {
                    foreach (var magazin in group)
                    {
                         magazinsName.Add( magazin.Name);                      
                    }
                }
            }
            return magazinsName;
        }

        public IEnumerable<HelpPublications> GetPublications()
        {
            Collections Collections = new Collections();
            var query = from x in Collections.Magazines
                        from y in Collections.Articles
                        where y.Name != null
                        from z in Collections.Publications
                        where (z.ArticleId == y.Id) &&
                        (z.MagazineId == x.Id)
                        orderby y.Name
                        select new HelpPublications(y.Name, x.Name);
            return query;
        }


    }
}
