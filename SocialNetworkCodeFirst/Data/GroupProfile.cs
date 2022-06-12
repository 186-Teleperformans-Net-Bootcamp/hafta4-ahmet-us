namespace SocialNetworkCodeFirst.Data
{
    public class GroupProfile
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<PrivateMessage> PrivateMessages { get; set; }
    }
}
