using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Collaborations
    {
        public int AuthorId { get;  }

        public int MagazineId { get; }

        public Collaborations(int authorId, int magazineId)
        {
            this.AuthorId = authorId;
            this.MagazineId = magazineId;
        }

        public override string ToString()
        {
            return string.Format(
                $"AuthorId = {this.AuthorId};" +
                $" magazinId = {this.MagazineId}\n");
        }
    }
}
