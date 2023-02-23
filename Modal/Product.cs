namespace foodshop.Modal
{
    public class Product
    {
        public int id { get; set; }
        public string product_image { get; set; }
        public string product_name { get; set; }
        public string product_price { get; set; }
        public double product_vote { get; set; }
        public int product_status { get; set; }
        public int product_view { get; set; }
        public int product_love { get; set; }
        public string product_description { get; set; }
        public int store_id { get; set; }
        public int product_category_id { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string product_code { get; set; }
    }
}
