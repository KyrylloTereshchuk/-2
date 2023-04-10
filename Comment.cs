using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Comment
    {
        public int ArticleId { get; set; }
        public string CommentText { get; set; }
        public DateTime PostedAt { get; set; }

        public Comment(int a, string b, DateTime c)
        {
            this.ArticleId = a;
            this.CommentText = b;
            this.PostedAt = c;
        }

        public override string ToString()
        {
            return string.Format(
                $"ArticleId = {this.ArticleId};" +
                $" commentText = {this.CommentText};" +
                $"  postedAt = {this.PostedAt}\n");
        }
    }
}
