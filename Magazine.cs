using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Magazine 
    {
        public int Id { get;  }

        public string Name { get;  }

        public string Periodicity { get;  }

        public DateOnly? Date { get; set; }

        public int Circulation { get;  }


        public Magazine(int magazinId, string nameOfTheMagazine, string periodicity, int circulation)
        {
            this.Id = magazinId;
            this.Name = nameOfTheMagazine ?? throw new ArgumentNullException(nameof(nameOfTheMagazine));
            this.Periodicity = periodicity; 
            this.Circulation = circulation;
        }

        public override string ToString()
        {
            return string.Format(
                $"Id = {this.Id};" +
                $" name = {this.Name};" +
                $" periodicity = {this.Periodicity};" +
                $" date = {this.Date};" +
                $" circulation = {this.Circulation}\n");
        }
    }

   
}
