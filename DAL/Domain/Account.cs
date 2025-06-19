using DAL.Statics;
using System.ComponentModel.DataAnnotations;

namespace DAL.Domain
{
    public class Account : ISoftDelete
    {
        public int Id { get; set; }
        [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
        [Display(Name = "الرقم التسلسلي")]
        public int SerialNumber { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
        [Length(3, 25, ErrorMessage = "يجب ان يكون الاسم مكون من 3 حروف وحتي 25 حرف")]
        [Display(Name = "الاسم")]
        public string Name { get; set; }

        [Display(Name = "العنوان")]
        public string? Address { get; set; }

        [Display(Name = "الوصف")]
        public string? Description { get; set; }

        [Display(Name = "معلومات اضافية")]
        public string? AdditionalInfo { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
        [Display(Name = "تاريخ انشاء الحساب")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "دائن")]
        public double Credit { get; protected set; }

        [Display(Name = "مدين")]
        public double Debit { get; protected set; }

        [Display(Name = "الحركات النقدية")]
        public List<Receipt> Receipts { get; set; } = [];
        public bool IsDeleted { get; set; }

        public Account()
        {
        }
        public Account(string name, int serialNumber, DateTime createdAt, string? address = null, string? description = null, string? additionalInfo = null)
        {
            SerialNumber = serialNumber;
            Name = name;
            Address = address;
            Description = description;
            AdditionalInfo = additionalInfo;
            CreatedAt = createdAt;
        }

        public virtual double AddRecipt(Receipt receipt)
        {
            if (receipt == null) throw new Exception("Receipt is null");
            //Go To Database
            Receipts.Add(receipt);
            return GetBalance();
        }

        public virtual double GetBalance()
        {
            double res = 0;
            foreach (var Receipt in Receipts)
            {
                if (Receipt.Type == ReceiptType.CashReceipt)
                    res += Receipt.MoneyAmount;
                else
                    res -= Receipt.MoneyAmount;
            }
            return res;
        }

    }
}
