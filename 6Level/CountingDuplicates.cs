using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1
//Подсчитайте количество дубликатов.
//    Напишите функцию, которая будет возвращать количество различных нечувствительных к регистру буквенных
// символов и числовых цифр, которые встречаются более одного раза во входной строке. Можно предположить,
// что входная строка содержит только буквы алфавита (как заглавные, так и строчные) и числовые цифры.

//    Пример
//    «abcde» -> 0 # no characters repeats more than once
//    «aabbcde» -> 2 # 'a' and 'b'
//    «aabBcde» -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
//    «неделимость» -> 1 # 'i' occurs six times
//    «Неделимости» -> 2 # 'i' occurs seven times and 's' occurs twice
//    «aA11» -> 2 # 'a' and '1'
//    «ABBA» -> 2 # 'A' and 'B' each occur twice

namespace CodewarsTask._6Level
{
    internal class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            return str.ToUpper().GroupBy(x => x).Where(x => x.Count() > 1).Count();
        }
    }
}
