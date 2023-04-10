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

        public static IEnumerable<Comment> CommentStartsWith(this IEnumerable<Comment> comments, string startsWith)
        {
            return comments.Where(a => a.CommentText.StartsWith(startsWith));
        }

        /*
        public static IEnumerable<Author> AuthorStartsWith(this IEnumerable<Author> comments, string startsWith)
        {
            return comments.Where(a => a.FullName.StartsWith(startsWith));
        }
        */
    }
}
