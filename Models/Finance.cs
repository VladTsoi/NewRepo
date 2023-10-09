namespace Calculator.Models
{
    public static class Finance
    {
        ///<summary>Вычисление аннуитетных займов<summary>
        public static List<PaymentModel> Annuitet(decimal loanSumm, int loanDeadline, decimal percentRate)
        {
            var paymentModule = new List<PaymentModel>();
            percentRate /= 12 * 100;
            decimal K = percentRate * Math.Pow((1 + percentRate), loanDeadline) / (Math.Pow((1 + percentRate), loanDeadline) - 1);
            decimal paymentBodySize = K * loanSumm;
            for (int i = 1; i <= loanDeadline; i++)
            {
                decimal paymentPercentSize = loanSumm * percentRate;
                decimal PrincipalBalance = paymentBodySize - paymentPercentSize;
                loanSumm -= PrincipalBalance;
                paymentModule.Add(new PaymentModel
                {
                    PaymentDate = DateTime.Now.AddMonths(i),
                    PaymentBodySize = paymentBodySize,
                    PaymentPercentSize = paymentPercentSize,
                    PrincipalBalance = PrincipalBalance,
                    OwedBalance = loanSumm
                });
            }
            return paymentModule;
        }

    }
}
