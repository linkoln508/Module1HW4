using System;

namespace Module1HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
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

            // string[] arrayString = new string[nums];

            // for (int i = 0; i < randomArray.Length; i++)
            // {
            //    arrayString[i] = randomArray[i].ToString();
            // }

            // Проверка на кол-во четных\нет элементов
            int unevenNums = 0;
            int evenNums = 0;

            for (int i = 0; i < randomArray.Length; i++)
            {
                if (randomArray[i] % 2 == 0)
                {
                    evenNums++;
                }
                else
                {
                    unevenNums++;
                }
            }

            int[] evenArray = new int[evenNums];
            int[] unArray = new int[unevenNums];

            for (int i = 0; i < randomArray; i++)
            {

            }

            foreach (var item in randomArray)
            {
                Console.Write("Четный масив: " + item + "\t");
            }

            foreach (var item in randomArray)
            {
                Console.Write("Нечетный масив: " + item + "\t");
            }
        }
    }
}
