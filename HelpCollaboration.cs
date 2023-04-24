using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class HelpCollaboration
    {
        public string Name { get;  }

        public string FullName { get;  }

        public HelpCollaboration(string magazinName, string authorFullName)
        {

            this.Name = magazinName;
            this.FullName = authorFullName;

        }

        public override string ToString()
        {
            return string.Format(
                $" Name = {this.Name};" +
                $" fullname = {this.FullName}\n");
        }
    }
}
