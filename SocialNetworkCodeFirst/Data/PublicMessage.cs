namespace SocialNetworkCodeFirst.Data
{
    public class PublicMessage
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
        public string WrittenText { get; set; }
        public string MediaLocation { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<PostComment> PostComments { get; set; }

        public virtual UserProfile UserProfile { get; set; }
    }
}
