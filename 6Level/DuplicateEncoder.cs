using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codewars.com/kata/54b42f9314d9229fd6000d9c
//Цель этого упражнения — преобразовать строку в новую строку, где каждый символ в новой строке — это "("если этот символ встречается только один раз в исходной строке или ")"
//если этот символ встречается более одного раза в исходной строке. Игнорируйте регистр букв при определении того, является ли символ дубликатом.

//    Примеры
//"din"      =>  "((("
//"recede"   =>  "()()()"
//"Success"  =>  ")())())"
//"(( @"     =>  "))((" 
//Примечания
//    Сообщения об утверждениях могут быть неясными относительно того, что они отображают в некоторых языках. Если вы читаете "...It Should encode XXX", то "XXX"это ожидаемый результат, а не ввод!

namespace CodewarsTask._6Level
{
    public class DuplicateEncoder
    {
        public static string DuplicateEncode(string word)
        {
            word = word.ToUpper();
            return string.Concat(word.Select(x => word.Count(e => e == x) > 1 ? ')' : '('));
        }
    }
}
