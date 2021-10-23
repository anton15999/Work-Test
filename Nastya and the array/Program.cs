using System;
using System.Linq;

namespace Nastya_and_the_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int seconds = 0;

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

            Console.WriteLine("Введите элементы массива через Enter:");

            int[] arr = new int[length];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr.Sum() != 0 && arr[i] != 0)
                {
                    int rev = -arr[i];

                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[j] != 0)
                        {
                            arr[j] = arr[j] + rev;
                        }
                    }

                    seconds++;
                }

                
            }

            Console.WriteLine("Количество секунд:" +seconds);
        }
    }
}
