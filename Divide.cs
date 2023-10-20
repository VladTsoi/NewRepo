using System.Linq;

namespace ArrayReplace
{
    public class Divide
    {
        /// <summary>
        /// Выходной массив
        /// </summary>
        private static object [] S;
        /// <summary>
        /// Метод по замене переменных при делении числа на 3 - fizz, на 5 - buzz
        /// </summary>
        /// <param name="M">входной массив</param>
        /// <param name="fizz">делитель fizz</param>
        /// <param name="buzz">делитель buzz</param>
        /// <param name="s1">заменяющая строка для fizz</param>
        /// <param name="s2">заменяющая строка для buzz</param>
        /// <returns></returns>
        public static object[] ArrayReplace(int[] M, int fizz, int buzz, string s1, string s2)
        {
            S = new object [M.Length];
            for (int i = 0; i < M.Count(); i++)
            {
                if (M[i] % fizz == 0) 
                {
                    S[i] = s1;
                    if (M[i] % buzz == 0)
                    {
                        S[i] += $"-{s2}";
                    }
                }
                else if (M[i] % buzz == 0)
                {
                    S[i] = s2;
                }
                else
                {
                    S[i] = M[i];
                }
                Print.Massive(S[i]);
            }
            return S;
        }
        /// <summary>
        /// Метод по замене переменных при делении числа на 3 - fizz, на 5 - buzz,
        /// на 4 - muzz, на 7 - guzz
        /// </summary>
        /// <param name="M">входной массив</param>
        /// <param name="fizz">делитель fizz</param>
        /// <param name="buzz">делитель buzz</param>
        /// <param name="guzz">делитель muzz</param>
        /// <param name="muzz">делитель guzz</param>
        /// <param name="s1">заменяющая строка для fizz</param>
        /// <param name="s2">заменяющая строка для buzz</param>
        /// <param name="s3">заменяющая строка для muzz</param>
        /// <param name="s4">заменяющая строка для guzz</param>
        /// <returns></returns>
        public static object[] ArrayReplace(int[] M, int fizz, int buzz, int muzz, int guzz,
            string s1, string s2, string s3, string s4)
        {
            S = new object[M.Length];
            for (int i = 0; i < M.Count(); i++)
            {
                if (M[i] % fizz == 0)
                {
                    S[i] = s1;
                    if (M[i] % buzz == 0)
                    {
                        S[i] += $"-{s2}";
                    }
                    if (M[i] % muzz == 0)
                    {
                        S[i] += $"-{s3}";
                    }
                    if (M[i] % guzz == 0)
                    {
                        S[i] += $"-{s4}";
                    }
                }
                else if (M[i] % buzz == 0)
                {
                    S[i] = s2;
                }
                else if (M[i] % muzz == 0)
                {
                    S[i] = s3;
                }
                else if (M[i] % guzz == 0)
                {
                    S[i] = s4;
                }
                else
                {
                    S[i] = M[i];
                }
                Print.Massive(S[i]);
            }
            return S;
        }
        /// <summary>
        /// Метод по замене переменных при делении числа на 3 - dog, на 5 - cat,
        /// на 4 - muzz, на 7 - guzz, если одновременно и на 3, и на 5, то заменяется 
        /// на good-boy
        /// </summary>
        /// <param name="M">входной массив</param>
        /// <param name="fizz">делитель fizz</param>
        /// <param name="buzz">делитель buzz</param>
        /// <param name="guzz">делитель muzz</param>
        /// <param name="muzz">делитель guzz</param>
        /// <param name="s1">заменяющая строка для fizz</param>
        /// <param name="s2">заменяющая строка для buzz</param>
        /// <param name="s3">заменяющая строка для muzz</param>
        /// <param name="s4">заменяющая строка для guzz</param>
        /// <returns></returns>
        public static object[] ArrayReplaceComplex(int[] M, int fizz, int buzz, int muzz, int guzz,
            string s1, string s2, string s3, string s4)
        {
            S = new object[M.Length];
            for (int i = 0; i < M.Count(); i++)
            {
                if (M[i] % fizz == 0)
                {
                    S[i] = "dog";
                    if (M[i] % buzz == 0)
                    {
                        s1 = "good";
                        s2 = "boy";
                        S[i] = $"{s1}-{s2}";                       
                    }
                    if (M[i] % muzz == 0)
                    {
                        if (S[i] == "dog")
                        {
                            S[i] = s1;
                        }
                        S[i] += $"-{s3}";
                    }
                    if (M[i] % guzz == 0)
                    {
                        S[i] += $"-{s4}";
                    }
                }
                else if (M[i] % buzz == 0)
                {
                    S[i] = "cat";
                }
                else if (M[i] % muzz == 0)
                {
                    S[i] = s3;
                }
                else if (M[i] % guzz == 0)
                {
                    S[i] = s4;
                }
                else
                {
                    S[i] = M[i];
                }
                Print.Massive(S[i]);
            }
            return S;
        }
    }
}
