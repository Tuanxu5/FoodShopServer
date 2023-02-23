namespace foodshop.Modal
{
    public class Comment
    {
        public int id { get; set; }
        public int users_id { get; set; }
        public int product_id { get; set; }
        public string comment_content { get; set; }
        public int comment_vote { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
