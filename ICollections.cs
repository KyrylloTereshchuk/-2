using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public interface ICollections
    {
        IEnumerable<Magazine> Magazines { get; }      
        IEnumerable<Magazine> MagazinesWithoutAuthor { get; }
        IEnumerable<Magazine> MagazinesWithoutEmployees { get; }
        IEnumerable<Author> Authors { get; }
        IEnumerable<Author> AuthorsWithoutWork { get; }
        IEnumerable<Article> Articles { get; }
        IEnumerable<Comment> Comments { get; }
        IEnumerable<Collaborations> Collaborations { get; }
        IEnumerable<Publications> Publications { get; }
    }
}
