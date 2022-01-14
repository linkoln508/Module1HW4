using System;

namespace Module1HW4
{
    public class Program
    {
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

            // Объявляю счетчики и Считаю кол-во четных\нет чисел
            int evenNumsCounter = 0;
            int unNumsCounter = 0;
            for (int i = 0; i < randomArray.Length; i++)
            {
                if (randomArray[i] % 2 == 0)
                {
                    evenNumsCounter++;
                }
                else
                {
                    unNumsCounter++;
                }
            }

            // Объявляю и Сортирую чет\не чет в массивы
            int[] evenNumsArray = new int[evenNumsCounter];
            int[] unNumsArray = new int[unNumsCounter];
            int evenTemp = 0;
            int unTemp = 0;
            for (int i = 0; i < randomArray.Length; i++)
            {
                if (randomArray[i] % 2 == 0)
                {
                    evenNumsArray[evenTemp] = randomArray[i];
                    evenTemp++;
                }
                else
                {
                    unNumsArray[unTemp] = randomArray[i];
                    unTemp++;
                }
            }

        }
    }
}
