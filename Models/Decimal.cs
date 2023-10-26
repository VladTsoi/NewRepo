namespace Calculator.Models
{
    public static class Decimal
    {
        ///<summary>Введение в степень числа типа decimal<summary>
        /// <param name="x">Число, которое нужно возвести в степень</param>
        /// <param name="y">Степень</param>
        /// <returns></returns>
        public static decimal Pow(decimal x, decimal y)
        {
            decimal result = x;
            for (int i = 1; i < y; i++)
            {
                result *= x;
            }
            return result;
        }
    }
}
