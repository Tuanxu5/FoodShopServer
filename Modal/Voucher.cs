namespace foodshop.Modal
{
    public class Voucher
    {
        public int id { get; set; }
        public string voucher_name { get; set; }
        public string voucher_code { get; set; }
        public DateTime voucher_start_time { get; set; }
        public DateTime voucher_end_time { get; set; }
        public int voucher_style { get; set; }
        public int voucher_reduction { get; set; }
        public int voucher_style_reduction { get; set; }
        public int voucher_condition { get; set; }
        public int voucher_count_use { get; set; }
        public int voucher_status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
