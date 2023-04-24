using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public interface IQueries
    {
        public IEnumerable<Article> GetArticles();
        public IEnumerable<HelpMagazinesNameAndPeriodicity> GetMagazinsNameAndPeriodicity();
        public IEnumerable<Comment> GetCommentsToArticle(int ArticleNumber);
        public IEnumerable<string> GetAuthorsStartWith(string BegginingOfName);
        public IEnumerable<Comment> GetCommentsToArticleLongerAndOlderThan(int MinSize, DateOnly MinDate);
        public IEnumerable<HelpCollaboration> GetCollaboration();
        public IEnumerable<Author> GetAuthorsWhereWorkplaceIs(string Workplace);
        public int GetMaxCirculation();
        public Article GetFirstArticleWithAuthorId(int AuthorId);
        public IEnumerable<Comment> GetCommentsWithUsePredicate(Func<string, bool> predicate);
        public IEnumerable<HelpArticlesAndCommentToIt> GetArticlesAndCommentToThem();
        public IEnumerable<Author> GetAuthorByCondition(int authorId, string Workplace1, string Workplace2);
        public IEnumerable<Magazine> GetMagazinFromTo(int MinId, int MaxId);
        public IEnumerable<HelpAuthorsAndTheirWorkplace> GetAuthorsAndTheirWorkplace();
        public IEnumerable<string> GetArticlesNameThatHaveComents();
        public int GetNumberOfCommentsToArticle(int ArticleId);
        public Magazine[] GetMagazinsArray();
        public ILookup<DateTime, string> GetLookup();
        public int GetTotalSize();
        public IEnumerable<Magazine> GetMagazinWithoutAuthors();
        public List<string> GetMagazinByPeriodicity(string periodicity);
        public IEnumerable<HelpPublications> GetPublications();
    }
}
