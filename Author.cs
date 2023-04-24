using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Lab1
{
    public class Author
    {
        public int Id { get;  }

        public string FullName { get;  }

        public string? Workplace { get; set; }

        public Author(int authorId, string fullName)
        {
            this.Id = authorId;
            this.FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
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
