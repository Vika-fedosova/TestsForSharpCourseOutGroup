using System.Text.RegularExpressions;

namespace Lab1.HomeWorks
{
    /// <summary>
    /// Методы обработки строк.
    /// Исходные условия: Метод принимает исходный массив строк, и возвращает результат обработки
    /// </summary>
    public class HomeWork2
    {
        /// <summary>
        /// Найти самую короткую и самую длинную строки. Вернуть найденные строки и их длину.
        /// </summary>
        /// <param name="temp">Исходный массив строк</param>
        /// <returns>Самая длинная строка, ее длина, самая маленькая трока и ее длина. Пример вывода return ("max1", 4, "min", 3);</returns>
        public static (string max, int lengthMax, string min, int lengthMin) Variant1(string[] temp)
        {
            int lengthMax = 0;
            int lengthMin = int.MaxValue;
            string max = "";
            string min = "";
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i].Length <= lengthMin)
                {
                    lengthMin = temp[i].Length;
                    min = temp[i];
                }
                if (temp[i].Length >= lengthMax)
                {
                    lengthMax = temp[i].Length;
                    max = temp[i];
                }
            }
            return (max, lengthMax, min, lengthMin);
        }

        /// <summary>
        /// Найти слово, состоящее только из цифр. Если таких слов больше одного, найти второе из них
        /// </summary>
        /// <param name="temp">Исходный массив строк</param>
        /// <returns>Слово состоящее только из цифр.</returns>
        public static string Variant2(string[] temp)
        {
            string number = null;
            Regex regex = new Regex(@"\D");
            foreach (string item in temp)
            {
                if (!regex.IsMatch(item))
                {
                    number = item;
                }
            }
            return number;
        }
    }
}