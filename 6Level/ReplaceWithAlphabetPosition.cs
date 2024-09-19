using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codewars.com/kata/546f922b54af40e1e90001da
//Добро пожаловать.
//    В этом ката вам необходимо, имея заданную строку, заменить каждую букву ее положением в алфавите.
//    Если в тексте есть что-то, что не является буквой, проигнорируйте это и не возвращайте.
//"a" = 1, "b" = 2, и т. д.

//    Пример
//    Input = "The sunset sets at twelve o' clock."
//Output = "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11"

namespace CodewarsTask._6Level
{
    public static class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string text)
        {
            string s = "";
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var elements = new Dictionary<string, int>();
            for (int j = 0; j < alphabet.Length; j++)
                elements.Add(alphabet.ToCharArray()[j].ToString(), j + 1);

            foreach (var v in text.ToUpper())
            {
                if (elements.ContainsKey(v.ToString()))
                    s = s + elements[v.ToString()] + " ";
            }

            return s.TrimEnd();
        }

    }
}
