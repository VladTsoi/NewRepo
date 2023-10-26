using System.ComponentModel.DataAnnotations;

namespace Calculator.Models
{
    public class PaymentCreditModel
    {
        [Display(Name = "Сумма займа:")]
        [Required(ErrorMessage = "Не указана cумма займа")]
        ///<summary>Сумма займа<summary>
        public int LoanSumm { get; set; }
        [Display(Name = "Срок займа:")]
        [Required(ErrorMessage = "Не указан срок займа")]
        ///<summary>Срок займа<summary>
        public int LoanDeadline { get; set; }
        [Display(Name = "Ставка:")]
        [Required(ErrorMessage = "Не указана ставка")]
        [Range(1, 99, ErrorMessage = "Недопустимая процентная ставка")]
        ///<summary>Ставка<summary>
        public decimal PercentRate { get; set; }
    }
}
