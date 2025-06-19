using DAL.Statics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Domain
{
    public class Receipt : ISoftDelete
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
        [Display(Name = "نوع الحركة")]
        public ReceiptType Type { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
        [Range(0, 1000000)]
        [Display(Name = "القيمة النقدية")]
        public double MoneyAmount { get; set; }

        [Display(Name = "الوصف")]
        public string? Description { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
        [Display(Name = "تاريخ انشاء الحساب")]
        public DateTime CreatedAt { get; set; }

        [ForeignKey(nameof(Account))]
        [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
        [Display(Name = "الحساب")]
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public bool IsDeleted { get; set; }

        public Receipt(ReceiptType type, double moneyAmount, DateTime createdAt, string? description = null)
        {
            Type = type;
            MoneyAmount = moneyAmount;
            Description = description;
            CreatedAt = createdAt;
        }
    }
}
