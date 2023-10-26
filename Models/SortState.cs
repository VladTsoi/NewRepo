using System.ComponentModel.DataAnnotations;

namespace Calculator.Models
{
    public enum SortState
    {
        PaymentDateAsc,
        PaymentDateDesc,
        PaymentBodySizeAsc,
        PaymentBodySizeDesc,
        PaymentPercentSizeAsc,
        PaymentPercentSizeDesc,
        PrincipalBalanceAsc,
        PrincipalBalanceDesc,
        OwedBalanceAsc,
        OwedBalanceDesc
    }
}
