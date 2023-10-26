using System.ComponentModel.DataAnnotations;

namespace Calculator.Models
{
    public class PaymentModel
    {
        [Display(Name = "Номер")]
        ///<summary>Номер<summary>
        public int? Id { get; set; }
        [Display(Name = "Дата платежа")]
        ///<summary>Дата платежа<summary>
        public DateTime? PaymentDate { get; set; }
        [Display(Name = "Размер платежа по телу")]
        ///<summary>Размер платежа по телу<summary>
        public decimal PaymentBodySize { get; set; }
        [Display(Name = "Размер платежа по проценту")]
        ///<summary>Размер платежа по проценту<summary>
        public decimal PaymentPercentSize { get; set; }
        [Display(Name = "Остаток основного долга")]
        ///<summary>Остаток основного долга<summary>
        public decimal PrincipalBalance { get; set; }
        [Display(Name = "Остаток долга")]
        ///<summary>Остаток долга<summary>
        public decimal OwedBalance { get; set; }
    }
}
