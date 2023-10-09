namespace Calculator.Models
{
    public static class Math
    {
        ///<summary>Введение в степень числа типа decimal<summary>
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
