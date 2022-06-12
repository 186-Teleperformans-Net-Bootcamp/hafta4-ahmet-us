namespace SocialNetworkCodeFirst.Data
{
    public class PostComment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int SourceId { get; set; }
        public string CommentText { get; set; }
        public DateTime Created { get; set; }

        public virtual PublicMessage PublicMessage { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public virtual PrivateMessage PrivateMessage { get; set; }

    }
}
