namespace foodshop.Modal
{
    public class Order
    {
        public string id { get; set; }
        public string user_name { get; set; }
        public string number_phone { get; set; }
        public string order_city { get; set; }
        public string order_district { get; set; }
        public string address_detail { get; set; }
        public string shipping { get; set; }
        public string payment { get; set; }
        public int order_status { get; set; }
        public string total { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public int store_id { get; set; }
        public int id_users { get; set; }
    }
}
