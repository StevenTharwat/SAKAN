using DAL.Domain;
using System.ComponentModel.DataAnnotations;

namespace ASPNetCore.Models
{
    public class ReceiptRowViewModel
    {
        [Required(ErrorMessage = "يجب تحديد نوع الحركة")]
        [Display(Name = "نوع الحركة")]
        public ReceiptType Type { get; set; }

        [Required(ErrorMessage = "يجب إدخال القيمة النقدية")]
        [Range(0, 1000000, ErrorMessage = "القيمة يجب أن تكون بين 0 و 1,000,000")]
        [Display(Name = "القيمة النقدية")]
        public double MoneyAmount { get; set; }

        [Display(Name = "الوصف")]
        public string? Description { get; set; }
    }

    public class CreateReceiptViewModel
    {
        [Required(ErrorMessage = "يجب تحديد نوع الحساب")]
        [Display(Name = "نوع الحساب")]
        public AccountType Type { get; set; }

        [Required(ErrorMessage = "يجب تحديد الحساب")]
        [Display(Name = "الحساب")]
        public int AccountId { get; set; }

        [Required(ErrorMessage = "يجب تحديد تاريخ الحركة")]
        [Display(Name = "تاريخ الحركة")]
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; } = DateTime.Today;

        public List<ReceiptRowViewModel> Rows { get; set; } = [];
    }
    public static class Helper
    {
        public static Receipt ToReceipt(this ReceiptRowViewModel row, CreateReceiptViewModel model)
        {
            var receipt = new Receipt(
                        row.Type,
                        row.MoneyAmount,
                        model.CreatedAt,
                        row.Description)
            {
                AccountId = model.AccountId
            };
            return receipt;
        }
    }
}