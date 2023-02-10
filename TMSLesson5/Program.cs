using System;
using System.Linq;
using System.Text;

namespace TMSLesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task2
            string stringTaskTwo = "экранирование индексирование конкатенация интерполяция итерация перегрузка";
            string[] wordsTaskTwo = stringTaskTwo.Split(' ');
            string lastShortestWord = wordsTaskTwo[0];
            string lastLongestWord = wordsTaskTwo[0];

            for (int i = 1; i < wordsTaskTwo.Length; i++)
            {
                if (wordsTaskTwo[i].Length <= lastShortestWord.Length) lastShortestWord = wordsTaskTwo[i];

                if (wordsTaskTwo[i].Length >= lastLongestWord.Length) lastLongestWord = wordsTaskTwo[i];
            }

            Console.WriteLine("TASK2");
            Console.WriteLine($"Строка: {stringTaskTwo}");
            Console.WriteLine($"Самое короткое слово: {lastShortestWord}");
            Console.WriteLine($"Самое длинное слово: {lastLongestWord}");
            Console.WriteLine();

            //task3
            string stringTaskThree = "abccc bhc3ndf aaaab erty err54rr k555";
            string[] wordsTaskThree = stringTaskThree.Split(' ');
            string firstShortestWord = wordsTaskThree[0];

            for (int i = 1; i < wordsTaskThree.Length; i++)
            {
                if (wordsTaskThree[i].Distinct().Count() < firstShortestWord.Distinct().Count()) firstShortestWord = wordsTaskThree[i];
            }

            Console.WriteLine("TASK3");
            Console.WriteLine($"Строка: {stringTaskThree}");
            Console.WriteLine($"Слово с минимальным набором символов: {firstShortestWord}");
            Console.WriteLine();

            //task4
            Console.WriteLine("TASK4");
            string stringTaskFour = "шабаш яблоко доход слон кабак ириска";
            string[] wordsTaskFour = stringTaskFour.Split(' ');
            Console.WriteLine($"Строка: {stringTaskFour}");
            
        insertNumber:
            Console.WriteLine("Введите номер слова для проверки (считать от 0):");
            int numberOfWord = Convert.ToInt32(Console.ReadLine());

            if (numberOfWord < 0 || numberOfWord >= wordsTaskFour.Length)
            {
                Console.WriteLine("Введенное значение выходит за границы допустимого диапазона");
                goto insertNumber;
            }

            string word = wordsTaskFour[numberOfWord];
            bool isPalindrome = true;

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (!word[i].Equals(word[word.Length - 1 - i]))
                {
                    isPalindrome = false; 
                    break;
                }
            }

            Console.WriteLine(isPalindrome ? $"Слово \"{word}\" является палиндромом" : $"Слово \"{word}\" не является палиндромом"); 
            Console.WriteLine();

            //task5
            Console.WriteLine("TASK5");
            Console.WriteLine("Введите произвольную строку:");
            StringBuilder stringBuilder = new StringBuilder(Console.ReadLine());
            int resultStringLength = stringBuilder.Length * 2;

            for (int i = 0; i < resultStringLength - 1; i += 2)
            {
                stringBuilder.Insert(i + 1, stringBuilder[i]);
            }

            Console.WriteLine($"Итоговая строка: {stringBuilder}");
            Console.ReadKey();
        }
    }
}