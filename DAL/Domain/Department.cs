using System.ComponentModel.DataAnnotations;

namespace DAL.Domain
{
    public class Department : Account, ISoftDelete
    {
        [Display(Name = "عدد السكان في الوحدة")]
        public int NumberOfPeople { get; set; }
    }
}
