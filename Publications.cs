using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Publications
    {
        public int ArticleId { get; set; }

        public int MagazinId { get; set; }

        public Publications(int a, int b)
        {
            this.ArticleId = a;
            this.MagazinId = b;
        }

        public override string ToString()
        {
            return string.Format(
                $"AuthorId = {this.ArticleId};" +
                $" magazinId = {this.MagazinId}\n");
        }
    }
}
