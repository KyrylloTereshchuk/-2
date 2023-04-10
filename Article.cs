using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Article
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public string Name { get; set; }

        public int SizeInPages { get; set; }

        public DateOnly Date { get; set; }

        
        public Article(int a, int b,  string c, int d, DateOnly e)
        {
            this.Id = a;
            this.AuthorId = b;
            this.Name = c;
            this.SizeInPages = d;
            this.Date = e;
        }

        public override string ToString()
        {
            return string.Format(
                $"Id = {this.Id};" +
                $" authorId = {this.AuthorId};" +
                $" name = {this.Name};" +
                $" sizeInPages = {this.SizeInPages};" +
                $"  date = {this.Date}\n");
        }
    }
}
