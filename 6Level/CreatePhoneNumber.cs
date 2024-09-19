using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codewars.com/kata/525f50e3b73515a6db000b83
//Напишите функцию, которая принимает массив из 10 целых чисел (от 0 до 9) и возвращает строку этих чисел в виде номера телефона.

//    Пример
//Kata.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }) // => returns "(123) 456-7890"
//Для выполнения этого задания необходимо вернуть правильный формат.

//    Не забудьте пробел после закрывающих скобок!
namespace CodewarsTask._6Level
{
    public class CreatePhoneNumbers
    {
        public static string CreatePhoneNumber(int[] n)
        {
            return $"({n[0]}{n[1]}{n[2]}) {n[3]}{n[4]}{n[5]}-{n[6]}{n[7]}{n[8]}{n[9]}";
        }
    }
}
