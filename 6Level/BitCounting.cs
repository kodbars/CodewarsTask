using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// https://www.codewars.com/kata/526571aae218b8ee490006f4
//Напишите функцию, которая принимает целое число в качестве входных данных и возвращает количество битов,
//которые равны единице в двоичном представлении этого числа. Вы можете гарантировать, что входные данные неотрицательны.

//    Пример : Двоичное представление 1234равно , поэтому в этом случае 10011010010функция должна вернуть 5

namespace CodewarsTask._6Level
{
    internal class BitCounting
    {
        public static int CountBits(int n)
        {
            return Convert.ToString(n, 2).ToCharArray().Where(e => !e.Equals('0')).Select(e => Convert.ToInt32(e.ToString())).Sum();
        }
    }
}
