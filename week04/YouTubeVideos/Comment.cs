public class Comment
{
    // Properties to store commenter name and comment text
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    // Constructor to initialize a comment
    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}