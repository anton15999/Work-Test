using System;
using System.Linq;
using System.Collections.Generic;

namespace Water_After_Rain
{
    class Program
    {
        static void Main(string[] args)
        {

            int length = 0;
            int leftend = 0;
            int middle = 0;
            int rightend = 0;
            int leftHigh = 0;
            List<int> leftarr = new List<int>();
            List<int> rightarr = new List<int>();
            int rightHigh = 0;

            int Sum = 0;

            Console.WriteLine("Введите количество элементов в массиве:");

            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите элементы массива через Enter:");

            int[] arr = new int[length];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            rightend = arr.Length - 1;

            for (var i = 1; i < rightend; i++)
            {
                leftarr = new List<int>();
                rightarr = new List<int>();

                leftarr.Add(arr[i]);

                leftHigh = arr[i];
                middle = arr[i];
                rightHigh = arr[i];

                for ( var j = i - 1; j >= 0; j--)
                {

                    if(arr[j] > leftHigh)
                    {
                        leftHigh = arr[j];
                        leftarr.Add(arr[j]);
                    }
                    else if( arr[j] == leftHigh)
                    {
                        leftarr.Add(arr[j]);
                    }
                    else if(arr[j] < leftHigh && middle == leftHigh)
                    {
                        leftHigh = arr[j];
                        break;
                    }
                    else
                    {
                        break;
                    }
                }

                for(var k = i + 1; k <= rightend; k++)
                {
                    if(arr[k] > rightHigh)
                    {
                        rightHigh = arr[k];
                        rightarr.Add(arr[k]);
                    }
                    else if(arr[k] == rightHigh)
                    {
                        rightarr.Add(arr[k]);
                    }
                    else if(arr[k] < rightHigh && middle == rightHigh)
                    {
                        rightHigh = arr[k];
                        break;
                    }
                    else
                    {
                        i = k;
                        break;
                    }
                }

                if (rightHigh > middle && leftHigh > middle)
                {

                    if (leftHigh < rightHigh)
                    {
                        rightHigh = leftHigh;
                    }
                    else
                    {
                        leftHigh = rightHigh;
                    }

                    for( var x = 0; x < leftarr.Count(); x++)
                    {
                        if (leftarr[x] < leftHigh)
                        {
                            leftarr[x] = leftHigh - leftarr[x];
                        }
                        else
                        {
                            leftarr[x] = 0;
                        }
                    }

                    for (var x = 0; x < rightarr.Count(); x++)
                    {
                        if (rightarr[x] < rightHigh)
                        {
                            rightarr[x] = rightHigh - rightarr[x];
                        }
                        else
                        {
                            rightarr[x] = 0;
                        }
                    }

                    leftarr.AddRange(rightarr);


                    Sum += leftarr.Sum();
                }
            }

            Console.WriteLine("Общее количество воды в лужах:" + Sum);
        }
    }
}
