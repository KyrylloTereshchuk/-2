using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class HelpPublications
    {
        public string ArticleName { get;  }

        public string MagazinName { get;  }

        public HelpPublications(string articleName, string magazinName)
        {

            this.ArticleName = articleName;
            this.MagazinName = magazinName;

        }

        public override string ToString()
        {
            return string.Format(
                $" Article name = {this.ArticleName};" +
                $" magazin name = {this.MagazinName}\n");
        }
    }
}
