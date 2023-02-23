namespace foodshop.Modal
{
    public class VoucherProduct
    {
        public int id { get; set; }
        public int voucher_id { get; set; }
        public int product_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
