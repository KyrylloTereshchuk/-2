using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Comment
    {
        public int ArticleId { get;  }
        public string CommentText { get; }
        public DateTime PostedAt { get; set; }

        public Comment(int articleId, string commentText)
        {
            this.ArticleId = articleId;
            this.CommentText = commentText ?? throw new ArgumentNullException(nameof(commentText));
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
