namespace foodshop.Modal
{
    public class OrderDetail
    {
        public int id { get; set; }
        public string order_id { get; set; }
        public int product_id { get; set; }
        public string product_image { get; set; }
        public string product_name { get; set; }
        public string price { get; set; }
        public int quality { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
}
