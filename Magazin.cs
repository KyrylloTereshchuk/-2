using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Magazin
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Periodicity { get; set; }

        public DateOnly Date { get; set; }

        public int Circulation { get; set; }


        public Magazin(int a, string b, string c, DateOnly d, int e)
        {
            this.Id = a;
            this.Name = b;
            this.Periodicity = c;
            this.Date = d;
            this.Circulation = e;
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
