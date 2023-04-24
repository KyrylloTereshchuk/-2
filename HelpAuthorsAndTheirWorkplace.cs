using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class HelpAuthorsAndTheirWorkplace
    {
        public string FullName { get;  }

        public string Name { get; }

        public HelpAuthorsAndTheirWorkplace(string authorFullName, string magazinName)
        {

            this.FullName = authorFullName;
            this.Name = magazinName;

        }

        public override string ToString()
        {
            return string.Format(
                $" Fullname = {this.FullName};" +
                $" name = {this.Name}\n");
        }
    }
}
