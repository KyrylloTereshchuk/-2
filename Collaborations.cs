using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Collaborations
    {
        public int AuthorId { get; set; }

        public int MagazinId { get; set; }

        public Collaborations(int a, int b)
        {
            this.AuthorId = a;
            this.MagazinId = b;
        }

        public override string ToString()
        {
            return string.Format(
                $"AuthorId = {this.AuthorId};" +
                $" magazinId = {this.MagazinId}\n");
        }
    }
}
