using Calculator.Models;
using Xunit;

namespace CalculatorTestProject
{
    public class CalculatorControllerTest
    {
        [Fact]
        public void ListOfAnnuitet()
        {
            // Arrange          
            var expected = new List<PaymentModel>
            {
                new PaymentModel() { PrincipalBalance = 1632.28m, PaymentBodySize = 1715.61m, PaymentPercentSize = 83.33m, OwedBalance = 8367.72m },
                new PaymentModel() { PrincipalBalance = 1645.88m, PaymentBodySize = 1715.61m, PaymentPercentSize = 69.73m, OwedBalance = 6721.84m },
                new PaymentModel() { PrincipalBalance = 1659.6m, PaymentBodySize = 1715.61m, PaymentPercentSize = 56.02m, OwedBalance = 5062.24m },
                new PaymentModel() { PrincipalBalance = 1673.43m, PaymentBodySize = 1715.61m, PaymentPercentSize = 42.19m, OwedBalance = 3388.81m },
                new PaymentModel() { PrincipalBalance = 1687.37m, PaymentBodySize = 1715.61m, PaymentPercentSize = 28.24m, OwedBalance = 1701.44m },
                new PaymentModel() { PrincipalBalance = 1701.44m, PaymentBodySize = 1715.61m, PaymentPercentSize = 14.18m, OwedBalance = 0 }
            };
            decimal loanSumm = 10000;
            int loanDeadline = 6;
            decimal percentRate = 10;
            // Act
            var actual = Finance.Annuitet(loanSumm, loanDeadline, percentRate);

            // Assert
            for (var i = 0; i < actual.Count(); i++)
            {
                Assert.Equal(expected[i].OwedBalance, Math.Round(actual[i].OwedBalance, 2));
                Assert.Equal(expected[i].PrincipalBalance, Math.Round(actual[i].PrincipalBalance, 2));
                Assert.Equal(expected[i].PaymentPercentSize, Math.Round(actual[i].PaymentPercentSize, 2));
                Assert.Equal(expected[i].PaymentBodySize, Math.Round(actual[i].PaymentBodySize, 2));
            }
        }
    }
}