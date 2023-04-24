using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public static class Extensions
    {
        public static IEnumerable<Author> WhereWorkplace(this IEnumerable<Author> authors, string workplace)
        {
            return authors.Where(author => author.Workplace == workplace);
        }

        public static IEnumerable<Author> AuthorStartsWith(this IEnumerable<Author> authors, string startsWith)
        {
            return authors.Where(a => a.FullName.StartsWith(startsWith));
        }

        public static IEnumerable<Comment> CommentStartsOrEndsWith(this IEnumerable<Comment> comments, Func<string, bool> startOrEnd)
        {
            return comments.Where(a => startOrEnd(a.CommentText));
        }


    }
}
