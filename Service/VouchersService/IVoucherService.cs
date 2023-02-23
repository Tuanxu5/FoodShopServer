using foodshop.Modal;

namespace foodshop.Service.Vouchers
{
    public interface IVoucherService
    {
        List<Voucher> GetVoucher();
        Boolean AddVoucher(Voucher voucher);
    }
}
