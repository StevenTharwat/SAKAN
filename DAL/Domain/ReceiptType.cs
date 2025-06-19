using System.ComponentModel.DataAnnotations;

namespace DAL.Domain
{
    public enum ReceiptType
    {
        [Display(Name = "حركة تحصيل")]
        CashReceipt,
        [Display(Name = "حركة دفع")]
        PaymentReceipt
    }
}
