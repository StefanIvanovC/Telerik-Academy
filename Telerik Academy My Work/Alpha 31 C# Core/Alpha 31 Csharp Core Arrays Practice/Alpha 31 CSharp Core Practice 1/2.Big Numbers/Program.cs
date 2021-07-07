using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = sizes[0];
            var b = sizes[1];
            var c = a + b;
            c = c + c;
            int[] digits = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] digits2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new List<int>();
            
            if (digits.Length > digits2.Length)
            {
                
                var isForAdd = 0;
                for (int i = 0; i < digits2.Length; i++)
                {

                    var currentFirst = digits[i];
                    var currentSecond = digits2[i];
                    var plus = currentFirst + currentSecond;

                    if (plus <= 9)
                    {
                        if (isForAdd > 0)
                        {
                            if (plus + 1 == 10)
                            {
                                list.Add(plus);
                            }
                            else
                            {
                                list.Add(plus + 1);
                            }
                            
                        }
                        else
                        {
                            list.Add(plus);
                        }
                        isForAdd = 0;
                        continue;
                    }
                    else
                    {
                        var minus = plus - 10 + isForAdd;
                        if (plus - 10 == 0)
                        {
                            minus = plus - 9 + isForAdd;
                        }
                        else
                        {
                            minus = plus - 10 + isForAdd;
                        }
                        list.Add(minus);
                        isForAdd++;
                        continue;
                    }

                }

                for (int i = digits2.Length; i < digits.Length; i++)
                {

                    list.Add(digits[i]);
                }
            }
            else if (digits.Length < digits2.Length)
            {

                var isForAdd = 0;
                for (int i = 0; i < digits.Length; i++)
                {

                    var currentFirst = digits[i];
                    var currentSecond = digits2[i];
                    var plus = currentFirst + currentSecond;

                    if (plus <= 9)
                    {
                        if (isForAdd > 0)
                        {
                            if (plus + 1 == 10)
                            {
                                list.Add(plus);
                            }
                            else
                            {
                                list.Add(plus + 1);
                            }
                            
                        }
                        else
                        {
                            list.Add(plus);
                        }
                        isForAdd = 0;
                        continue;
                    }
                    else
                    {
                        var minus = plus - 10 + isForAdd;
                        if (plus - 10 == 0)
                        {
                            minus = plus - 9 + isForAdd;
                        }
                        else
                        {
                            minus = plus - 10 + isForAdd;
                        }
                        list.Add(minus);
                        isForAdd++;
                        continue;
                    }

                }

                for (int i = digits.Length; i < digits2.Length; i++)
                {

                    list.Add(digits2[i]);
                }
            }
            else if (digits.Length == digits2.Length)
            {
                var isForAdd = 0;
                for (int i = 0; i < digits.Length; i++)
                {
                    
                    var currentFirst = digits[i];
                    var currentSecond = digits2[i];
                    var plus = currentFirst + currentSecond;
                    
                    if (plus <= 9)
                    {
                        if (isForAdd > 0)
                        {
                            if (plus + 1 == 10)
                            {
                                list.Add(plus);
                            }
                            else
                            {
                                list.Add(plus + 1);
                            }
                            
                        }
                        else
                        {
                            list.Add(plus);
                        }
                        isForAdd = 0;
                        continue;
                    }
                    else
                    {
                        var minus = plus - 10 + isForAdd;
                        if (plus - 10 == 0)
                        {
                            minus = plus - 9 + isForAdd;
                        }
                        else
                        {
                            minus = plus - 10 + isForAdd;
                        }
                        list.Add(minus);
                        isForAdd++;
                        continue;
                    }

                }
            }

            Console.WriteLine(string.Join(" ", list));











            //int next = 0;
            //List<int> sum = new List<int>();


            //if (digits.Length == digits2.Length)
            //{
            //    for (int i = 0; i < digits.Length; i++)
            //    {

            //        var sumDigits = digits[i] + digits2[i];
            //        if (sumDigits > 10)
            //        {

            //        }
            //    }
            //}


            //if (digits.Length == digits2.Length)
            //{
            //    for (int i = 0; i < digits.Length; i++)
            //    {
            //        var first = digits[i];
            //        var second = digits2[i];


            //        var sumCurrent = first + second; 
            //        if (sumCurrent > 9)
            //        {
            //            next = 1;
            //        }
            //        else
            //        {
            //            next = 0;
            //        }
            //        if (i > 0)
            //        {
            //            if (sumCurrent <= 9)
            //            {
            //                sum.Add(sumCurrent);
            //            }
            //            else
            //            {
            //                sumCurrent = sumCurrent % 10;
            //                sum.Add(sumCurrent);
            //            }
            //        }

            //    }
            //}

            //Console.WriteLine(string.Join(" ", sum));

            //var currentSmaler = 0;
            //var currentBigger = 0;
            //bool isFirstBigger = true;
            //if (digits.Length < digits2.Length)
            //{
            //    currentSmaler = digits.Length;
            //    currentBigger = digits2.Length;
            //    isFirstBigger = false;
            //}
            //else
            //{
            //    currentSmaler = digits2.Length;
            //    currentBigger = digits.Length;
            //    isFirstBigger = true;
            //}

            //for (int i = 0; i < currentSmaler; i++)
            //{
            //    if (sum.Count == 0)
            //    {
            //        break;
            //    }

            //    var first = digits[i];
            //    var second = digits2[i];

            //    var sumCurrent = first + second;
            //    if (sumCurrent <= 9)
            //    {
            //        sum.Add(sumCurrent);
            //    }
            //    else
            //    {
            //        sumCurrent = sumCurrent % 10;
            //        sum.Add(sumCurrent);
            //    }
            //}

            //int difference = currentBigger - currentSmaler;

            //if (isFirstBigger)
            //{
            //    for (int i = 0; i < difference; i++)
            //    {
            //        var currentDig = digits[digits.Length - 1 - i];
            //        sum.Add(currentDig);
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < difference; i++)
            //    {
            //        var currentDig = digits2[digits2.Length - 1 - i];
            //        sum.Add(currentDig);
            //    }

            //}


        }
    }
}
