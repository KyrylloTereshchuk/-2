using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Lab1

{
    public class Author
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Workplace { get; set; }

        public Author(int a, string b, string c)
        {
            this.Id = a;
            this.FullName = b;
            this.Workplace = c;
        }


        public override string ToString()
        {
            return string.Format(
                $"Id = {this.Id};" +
                $" fullname = {this.FullName};" +
                $" workplace = {this.Workplace}\n");
        }


    }
}
