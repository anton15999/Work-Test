using System;

namespace Mashka_and_Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int difficulty = 0;
            int solvedProblems = 0;


            Console.WriteLine("Введите количество элементов в массиве:");

            do
            {
                if (!int.TryParse(Console.ReadLine(), out length))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число для длинны массива от 1");
                }
                else if (length < 1)
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число больше 0");
                }
            } while (length < 1);


            Console.WriteLine("Введите максимальную сложность, с которой может справится Мишка:");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out difficulty))
                {
                    Console.WriteLine("Ошибка ввода! Сложность с которой может справится Мишка не может быть меньше 1 и больше 100");
                }
                else if (difficulty < 1)
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число больше 1");
                }
                else if( difficulty > 100)
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число меньше 100");
                }
            } while (difficulty < 1 || difficulty > 100);

            Console.WriteLine("Введите элементы массива через Enter:");

            int[] arr = new int[length];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int LeftSide = 0;
            int RightSide = length - 1;
            int count = 0;

            if (arr.Length > 1)
            {
                while ((arr[LeftSide] <= difficulty || arr[RightSide] <= difficulty) && LeftSide <= RightSide)
                {

                    if (LeftSide != RightSide)
                    {
                        if (arr[LeftSide] <= difficulty)
                        {
                            solvedProblems++;
                            LeftSide++;
                        }

                        if (arr[RightSide] <= difficulty)
                        {
                            solvedProblems++;
                            RightSide--;
                        }
                    }
                    else
                    {
                        if (arr[LeftSide] <= difficulty)
                        {
                            solvedProblems++;
                            LeftSide++;
                        }
                    }

                    count++;

                    if (count > length + 5)
                    {
                        break;
                    }
                }
            }
            else
            {
                if(arr[LeftSide] <= difficulty)
                {
                    solvedProblems++;
                }
            }

            Console.WriteLine("Количество решенных проблем:" + solvedProblems);
        }
    }
}
