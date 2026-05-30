using System;

namespace YoutubeVideos
{
    public class Comment
    {
        private string _commenterName;
        private string _commentText;

        public Comment(string commenterName, string commenterText)
        {
            _commenterName = commenterName;
            _commentText = commenterText;
        }

        public string GetCommenterName()
        {
            return _commenterName;
        }

        public string GetCommenterText()
        {
            return _commentText;
        }
    }
}