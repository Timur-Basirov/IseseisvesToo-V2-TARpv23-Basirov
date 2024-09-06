//В заданной строке текста определите количество слов. Каждое слово отделено друг от друга пробелом. Посчитать кол-во слов и пробелов в тексте. 
using System;
using System.Linq;

namespace BashirovTARpv23
{
    internal class Ulesanne01
    {

        public static void Ulesanne()
        {
            Console.WriteLine("Sisestage lause:");//kasutajalt ettepaneku/teksti küsimine /запрашиваю у пользователя предложение/текст
            string? text = Console.ReadLine();

            if (!string.IsNullOrEmpty(text))//teksti kontrollimine tekstis/проверяю на присутствие текста в text
            {
                int wordCount = text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
                int spaceCount = text.Count(c => c == ' ');
                Console.WriteLine($"Sõnade arv:{wordCount}");
                Console.WriteLine($"Lünkade arv:{spaceCount}");
            }
            else
            {
                Console.WriteLine("Te ei ole sisestanud lauset.");//tekst puudub/текста нет

            }
        }
    }
}