using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    // Ritch model | ananemic model 
    //         
    // muttable   immutable 

    public class Publications
    {
        public int ArticleId { get;  }

        public int MagazineId { get;  }

        public Publications(int articleId, int magazineId)
        {
            this.ArticleId = articleId;
            this.MagazineId = magazineId;
        }

        public override string ToString()
        {
            return string.Format(
                $"AuthorId = {this.ArticleId};" +
                $" magazinId = {this.MagazineId}\n");
        }
    }
}
