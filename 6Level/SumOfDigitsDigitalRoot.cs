using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codewars.com/kata/541c8630095125aba6000c00
//Цифровой корень — это рекурсивная сумма всех цифр числа.

//    Учитывая n, возьмите сумму цифр n. Если это значение имеет более одной цифры, продолжайте
//уменьшать таким образом, пока не получится однозначное число. Входными данными будет неотрицательное целое число.

//    Примеры
//16  -->  1 + 6 = 7
//942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
//132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
//493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2

namespace CodewarsTask._6Level
{
    public class SumOfDigitsDigitalRoot
    {
        public static int DigitalRoot(long n)
        {
            while (true)
            {
                if (n.ToString().ToCharArray().Length > 1)
                {
                    n = n.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).Sum();
                    continue;
                }
                return (int)n;
            }
        }
    }
}
