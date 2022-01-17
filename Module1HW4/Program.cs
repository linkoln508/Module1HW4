using System;
using System.Text;

namespace Module1HW4
{
    public class Program
    {
        private static int oddUpperCount = 0;
        private static int evenUpperCount = 0;

        // Метод конвертирования int в char. Получаю номер символа "a" для начала заполнения массива символами ASCII. Сверяю с символами для верхнего регистра и присваиваю в массив.
        // Считаю Кол-во символов приведенных к верхнему Регистру. Возвращаю Массив char.
        public static char[] IntConvertToString(int[] arr)
        {
            char[] strArr = new char[arr.Length];
            int alphabetStartIndex = 'a' - 1;
            for (int i = 0; i < arr.Length; i++)
            {
                char letter = Convert.ToChar(alphabetStartIndex + arr[i]);

                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'd' || letter == 'h' || letter == 'j')
                {
                    if (arr[i] % 2 == 0)
                    {
                        evenUpperCount++;
                    }
                    else
                    {
                        oddUpperCount++;
                    }

                    letter = char.ToUpper(letter);
                }

                strArr[i] = letter;
            }

            return strArr;
        }

        public static void Main(string[] args)
        {
            // Ввожу кол-во Элем. массива и вывожу циклом
            Console.Write("Введите кол-во элементов массива: ");
            int nums = int.Parse(Console.ReadLine());
            int[] randomArray = new int[nums];

            Random random = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(1, 26);
            }

            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.Write(randomArray[i] + "\t");
            }

            // Объявляю счетчики и Считаю кол-во чет\нет чисел
            int evenNumsCounter = 0;
            int oddNumsCounter = 0;
            for (int i = 0; i < randomArray.Length; i++)
            {
                if (randomArray[i] % 2 == 0)
                {
                    evenNumsCounter++;
                }
                else
                {
                    oddNumsCounter++;
                }
            }

            // Объявляю и Сортирую чет\нет в массивы
            int[] evenNumsArray = new int[evenNumsCounter];
            int[] oddNumsArray = new int[oddNumsCounter];
            int evenTemp = 0;
            int oddTemp = 0;
            for (int i = 0; i < randomArray.Length; i++)
            {
                if (randomArray[i] % 2 == 0)
                {
                    evenNumsArray[evenTemp] = randomArray[i];
                    evenTemp++;
                }
                else
                {
                    oddNumsArray[oddTemp] = randomArray[i];
                    oddTemp++;
                }
            }

            var evenAlphabet = IntConvertToString(evenNumsArray);
            var oddAlphabet = IntConvertToString(oddNumsArray);

            Console.WriteLine();

            if (oddUpperCount > evenUpperCount)
            {
                Console.WriteLine($"В нечётном массиве на {oddUpperCount - evenUpperCount} больше заглавных букв, чем в чётном");
            }
            else if (oddUpperCount < evenUpperCount)
            {
                Console.WriteLine($"В чётном массиве на {evenUpperCount - oddUpperCount} больше заглавных букв, чем в нечётном");
            }
            else
            {
                Console.WriteLine($"В чётном массиве {evenUpperCount} заглавных букв, как и в нечётном");
            }

            Console.WriteLine("Чётный");
            Console.WriteLine(string.Join(' ', evenAlphabet));

            Console.WriteLine("Нечётный");
            Console.WriteLine(string.Join(' ', oddAlphabet));
        }
    }
}