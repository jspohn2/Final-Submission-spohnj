namespace BasicMVC.Models
{
    public class Comment // child table
    {

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public string CommentText { get; set; } = string.Empty;
        public string OwnerID { get; set; } = string.Empty; // represents the physical value in the database
        public MVCUser Owner { get; set; } = null!; // navigation property for MVCUser object
        public int PostIdNumber { get; set; }

        // navigation principal one side
        public Post Post { get; set; } = null!;
    }
}