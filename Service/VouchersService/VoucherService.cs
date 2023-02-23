using foodshop.Data;
using foodshop.Modal;
using foodshop.Service.Vouchers;

namespace foodshop.Service.VouchersService
{
    public class VoucherService : IVoucherService
    {
        public readonly VoucherDbContext _voucherDbContext;
        public VoucherService(VoucherDbContext voucherDbContext)
        {
            _voucherDbContext = voucherDbContext;
        }
        public bool AddVoucher(Voucher voucher)
        {
            _voucherDbContext.Vouchers.Add(voucher);
            _voucherDbContext.SaveChanges();
            return true;
        }

        public List<Voucher> GetVoucher()
        {
            return _voucherDbContext.Vouchers.OrderByDescending(p => p.id).ToList();
        }
    }
}
