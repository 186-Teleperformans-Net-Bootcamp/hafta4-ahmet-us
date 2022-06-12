namespace SocialNetworkCodeFirst.Data
{
    public class PrivateMessage
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
        public int TargetId { get; set; }
        public string WrittenText { get; set; }
        public string MediaLocation { get; set; }
        public DateTime Created { get; set; }

        public virtual ICollection<PostComment> PostComments { get; set; }
        
        public virtual GroupProfile GroupProfile { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
