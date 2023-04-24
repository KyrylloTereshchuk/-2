using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class HelpMagazinesNameAndPeriodicity
    {
        public string Name { get;  }

        public string Periodicity { get;  }

        public HelpMagazinesNameAndPeriodicity( string magazineName, string periodicity)
        {

            this.Name = magazineName;
            this.Periodicity = periodicity;

        }

        public override string ToString()
        {
            return string.Format(
                $" Name = {this.Name};" +
                $" periodicity = {this.Periodicity}\n");
        }
    }
}
