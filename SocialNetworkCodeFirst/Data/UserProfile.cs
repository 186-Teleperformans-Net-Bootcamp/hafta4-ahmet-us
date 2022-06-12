namespace SocialNetworkCodeFirst.Data
{
    public class UserProfile
    {
        public int Id { get; set; } 
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
        public DateTime CreatedDate { get; set; }
        
        public virtual ICollection<PrivateMessage> PrivateMessages { get; set; }
        public virtual ICollection<PublicMessage> PublicMessages { get; set; }
        public virtual ICollection<PostComment> PostComments { get; set; }

    }
}
