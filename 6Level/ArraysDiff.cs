using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codewars.com/kata/523f5d21c841566fde000009
//Ваша цель в этом ката — реализовать функцию разности, которая вычитает один список из другого и возвращает результат.

//    Он должен удалить все значения из списка a, которые присутствуют в списке, bсохраняя их порядок.

//    Kata.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }) => new int[] { 2 }
//Если значение присутствует в b, все его вхождения должны быть удалены из другого:

//Kata.ArrayDiff(new int[] { 1, 2, 2, 2, 3 }, new int[] { 2 }) => new int[] { 1, 3 }

namespace CodewarsTask._6Level
{
    public class ArraysDiff
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            List<int> list1 = new List<int>(b);
            List<int> list2 = new List<int>(a);
            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1[i] == list2[j])
                    {
                        list2.RemoveAt(j);
                        --j;
                    }
                }
            }
            return list2.ToArray();
        }
    }
}
