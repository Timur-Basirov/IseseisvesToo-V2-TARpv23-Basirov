//Задан одномерный массив целых чисел, заполненый случайным образом. Образуйте из него два отсортированных по возрастанию массива, содержащих четные и нечетные числа. Подсказка: четное число делится на 2 без остатка.
using System;
using System.Linq;

namespace BashirovTARpv23
{
    internal class Ulesanne02
    {
        public static void Ulesanne()
        {
            Random random = new Random();//juhuslik massiivi/cлучайный массив
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);//numbrid 1 kuni 100/числа от 1 до 100
            }

            Console.WriteLine("Allikamassiiv:");//massiivi väljund/вывод массива
            Console.WriteLine(string.Join(", ", array));

            int[] evennumbers = array.Where(x => x % 2 == 0).ToArray();//massiivi moodustamine, paariline ja paaritu/формирование массивов, четных и нечетных
            Array.Sort(evennumbers);//сортировка

            int[] oddnumbers = array.Where(x => x % 2 != 0).ToArray();
            Array.Sort(oddnumbers);

            //вывод массивов четных/нечетных чисел
            Console.WriteLine("\nPaarisarvude massiivi:");
            Console.WriteLine(string.Join(", ", evennumbers));//komade lisamine väljundi jaoks/добавление запятых для вывода

            Console.WriteLine("\nPaaritute numbrite massiivi:");
            Console.WriteLine(string.Join(", ", oddnumbers));

        }
    }
}