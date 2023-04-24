using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Article
    {
        public int Id { get;  }

        public int AuthorId { get;  }

        public string? Name { get;  }

        public int SizeInPages { get; set; }

        public DateOnly? Date { get; set; }

        
        public Article(int articleId, int authorId,  string nameOfTheArticle, int sizeInPages)
        {
            this.Id = articleId;
            this.AuthorId = authorId;
            this.Name = nameOfTheArticle ?? throw new ArgumentNullException(nameof(nameOfTheArticle));
            this.SizeInPages = sizeInPages;
        }

        public Article(int sizeInPages)

        {
            this.SizeInPages = sizeInPages;
        }

        public override string ToString()
        {
            return string.Format(
                $"Id = {this.Id};" +
                $" authorId = {this.AuthorId};" +
                $" name = {this.Name};" +
                $" sizeInPages = {this.SizeInPages};" +
                $" date = {this.Date}\n");
        }
    }
}
