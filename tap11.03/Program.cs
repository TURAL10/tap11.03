using System;
using System.Diagnostics;

namespace tap11._03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task 1

            //int num;
            //l1:
            //Console.Write("ededi daxil edin: ");
            //string income = Console.ReadLine();
            //if (!int.TryParse(income, out num))
            //{
            //    goto l1;
            //}
            //else if (num % 2 == 0)
            //{
            //    Console.WriteLine("Cut eded'dir");
            //}
            //else
            //{
            //    Console.WriteLine("Tek eded'dir");
            //}

            #endregion

            #region Task 2

            //    int num1, num2;
            //l1:
            //    Console.Write("1ci ededi daxil edin: ");
            //    string income1 = Console.ReadLine();
            //    if (!int.TryParse(income1, out num1))
            //    {
            //        goto l1;
            //    }
            //l2:
            //    Console.Write("2ci ededi daxil edin: ");
            //    string income2 = Console.ReadLine();
            //    if (!int.TryParse(income2, out num2))
            //    {
            //        goto l2;
            //    }

            //    else if (num1 % num2 == 0) 
            //    {
            //        int result = num1 / num2;
            //        Console.WriteLine($"Cavab: {result}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bolunmur");
            //    }

            #endregion

            #region Task 3

            //    int num;
            //l1:
            //    Console.Write("ededi daxil edin: ");
            //    string income = Console.ReadLine();
            //    if (!int.TryParse(income, out num))
            //    {
            //        goto l1;
            //    }
            //    else if (num % 10 == 7)
            //    {
            //        Console.WriteLine("Beli");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Xeyir");
            //    }

            #endregion

            #region Task 4

            //    int num1;
            //    int uzunluq1;
            //l1:
            //    Console.Write("Ededi daxil edin: ");
            //    int.TryParse(Console.ReadLine(), out num1);
            //    uzunluq1 = (int)Math.Log10(num1) + 1;
            //    if (uzunluq1 != 2) 
            //    {
            //        goto l1;
            //    }

            //    int firstDigit = num1 / 10;
            //    int secontDigit = num1 % 10;

            //    if (firstDigit == secontDigit) 
            //    {
            //        Console.WriteLine("Eynidir");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ferqlidir");
            //    }

            #endregion

            #region Task 5

            //    int num1;
            //    int uzunluq1;
            //l1:
            //    Console.Write("Ededi daxil edin: ");
            //    int.TryParse(Console.ReadLine(), out num1);
            //    uzunluq1 = (int)Math.Log10(num1) + 1;
            //    if (uzunluq1 != 2)
            //    {
            //        goto l1;
            //    }

            //    int firstDigit = num1 / 10;
            //    int secontDigit = num1 % 10;
            //    int sum = firstDigit + secontDigit;

            //    if (sum % 2 == 0) 
            //    {
            //        Console.WriteLine(firstDigit * secontDigit);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Reqemlerin cemi cut deyil");
            //    }

            #endregion

            #region Task 6

            //    int num1;
            //    int uzunluq1;
            //l1:
            //    Console.Write("Ededi daxil edin: ");
            //    int.TryParse(Console.ReadLine(), out num1);
            //    uzunluq1 = (int)Math.Log10(num1) + 1;
            //    if (uzunluq1 != 3)
            //    {
            //        goto l1;
            //    }

            //    int firstDigit = num1 / 100;
            //    int secontDigit = (num1 - (firstDigit * 100)) / 10;
            //    int thirdDigit = num1 % 10;

            //    if (firstDigit + thirdDigit == secontDigit) 
            //    {
            //        Console.WriteLine("Beli");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Xeyir");
            //    }

            //    Console.WriteLine($"1ci reqem: {firstDigit}");
            //    Console.WriteLine($"2ci reqem: {secontDigit}");
            //    Console.WriteLine($"3cu reqem: {thirdDigit}");


            #endregion

            #region Task 7

            //    int num1;
            //    int uzunluq1;
            //l1:
            //    Console.Write("Ededi daxil edin: ");
            //    int.TryParse(Console.ReadLine(), out num1);
            //    uzunluq1 = (int)Math.Log10(num1) + 1;
            //    if (uzunluq1 != 3)
            //    {
            //        goto l1;
            //    }

            //    int firstDigit = num1 / 100;
            //    int secontDigit = (num1 - (firstDigit * 100)) / 10;
            //    int thirdDigit = num1 % 10;

            //    if (firstDigit + thirdDigit + secontDigit == firstDigit * firstDigit)
            //    {
            //        Console.WriteLine("Beli");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Xeyir");
            //    }

            //    Console.WriteLine($"1ci reqem: {firstDigit}");
            //    Console.WriteLine($"2ci reqem: {secontDigit}");
            //    Console.WriteLine($"3cu reqem: {thirdDigit}");

            #endregion

            #region Task 8s

            //    int num1;
            //l1:
            //    Console.Write("reqemi daxil edin:");
            //    int.TryParse(Console.ReadLine(), out num1);

            //    int day = num1 % 10;
            //    switch (day)
            //    {
            //        case 1:
            //            Console.WriteLine("Monday");
            //            break;
            //        case 2:
            //            Console.WriteLine("Tuesday");
            //            break;
            //        case 3:
            //            Console.WriteLine("Wednesday");
            //            break;
            //        case 4:
            //            Console.WriteLine("Thursday");
            //            break;
            //        case 5:
            //            Console.WriteLine("Friday");
            //            break;
            //        case 6:
            //            Console.WriteLine("Saturday");
            //            break;
            //        case 7:
            //            Console.WriteLine("Sunday");
            //            break;
            //        default:
            //            Console.WriteLine("Veriler serte uygun deyil");
            //            break;
            //    }



            #endregion

            #region Task 9s

            //    int num1;
            //l1:
            //    Console.Write("reqemi daxil edin:");
            //    int.TryParse(Console.ReadLine(), out num1);
            //    switch (num1)
            //    {
            //        case < 1:
            //        case > 12:
            //            goto l1;

            //        default:
            //            switch (num1)
            //            {
            //                case 1:
            //                    Console.WriteLine("January");
            //                    break;
            //                case 2:
            //                    Console.WriteLine("February");
            //                    break;
            //                case 3:
            //                    Console.WriteLine("March");
            //                    break;
            //                case 4:
            //                    Console.WriteLine("April");
            //                    break;
            //                case 5:
            //                    Console.WriteLine("May");
            //                    break;
            //                case 6:
            //                    Console.WriteLine("June");
            //                    break;
            //                case 7:
            //                    Console.WriteLine("July");
            //                    break;
            //                case 8:
            //                    Console.WriteLine("August");
            //                    break;
            //                case 9:
            //                    Console.WriteLine("Septenber");
            //                    break;
            //                case 10:
            //                    Console.WriteLine("October");
            //                    break;
            //                case 11:
            //                    Console.WriteLine("November");
            //                    break;
            //                case 12:
            //                    Console.WriteLine("December");
            //                    break;
            //            }
            //            break;
            //    }



            #endregion

            #region Task 10

            //int[] arr = new int[6];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"arr[{i}]=");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int max = 0;
            //int min = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > arr[max])
            //        max = i;

            //    if (arr[i] < arr[min])
            //        min = i;
            //}
            //Console.WriteLine("en boyuk index:" + max + " en kicik index:" + min);
            //Console.WriteLine("en boyuk reqem:" + arr[max] + " en kicik reqem" + arr[min]);

            #endregion

            #region Task 11

            //    int num1;
            //    int uzunluq1;
            //l1:
            //    Console.Write("Ededi daxil edin: ");
            //    int.TryParse(Console.ReadLine(), out num1);
            //    uzunluq1 = (int)Math.Log10(num1) + 1;
            //    if (uzunluq1 != 6)
            //    {
            //        goto l1;
            //    }

            //    int temp = num1 % 1000;
            //    num1 /= 1000;
            //    int firstDigit = num1 / 100;
            //    int secontDigit = (num1 - (firstDigit * 100)) / 10;
            //    int thirdDigit = num1 % 10; 

            //    int fourthDigit = temp / 100;
            //    int fivethDigit = (temp - (fourthDigit * 100)) / 10;
            //    int sixthDigit= temp % 10;



            //    if (firstDigit + secontDigit + thirdDigit == fourthDigit + fivethDigit + sixthDigit) 
            //    {
            //        int a = firstDigit * 1000 + secontDigit * 100 + fivethDigit * 10 + sixthDigit;
            //        int b = thirdDigit * 10 + fourthDigit;
            //        int result = a + b;
            //        Console.WriteLine($"Alinan cavab: {result}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Serte uygun deyil");
            //    }

            #endregion

            #region Task 12

            //    int num1;
            //    int uzunluq1;
            //l1:
            //    Console.Write("Ededi daxil edin: ");
            //    int.TryParse(Console.ReadLine(), out num1);
            //    uzunluq1 = (int)Math.Log10(num1) + 1;
            //    if (uzunluq1 != 6)
            //    {
            //        goto l1;
            //    }

            //    int a = 8 * (int)Math.Pow(10, uzunluq1 + 1) + num1 * 10 + 8;

            //    int f42l = a / 10000;
            //    int l42f = a % 10000 * 10000;
            //    int reverce = l42f + f42l;

            //    int qaliq;
            //    int result = 0;
            //    int pow1 = 0;
            //    while (reverce > 0)
            //    {
            //        qaliq = reverce % 10;
            //        reverce /= 100;
            //        result += qaliq * (int)Math.Pow(10,pow1);
            //        pow1 += 2;
            //    }
            //    Console.WriteLine(result);

            #endregion

            #region Task 13

            //    int num1, uzunluq1;
            //l1:
            //    Console.Write("reqemi daxil edin:");
            //    int.TryParse(Console.ReadLine(), out num1);
            //    uzunluq1 = (int)Math.Log10(num1) + 1;
            //    if (uzunluq1 != 7)
            //    {
            //        goto l1;
            //    }

            //    int newNumber = 0;

            //    int temp = num1;

            //    while (temp > 0)
            //    {
            //        int qaliq = temp % 10;
            //        newNumber = newNumber * 10 + qaliq;
            //        temp /= 10;
            //    }

            //    int count = 0;
            //    if(newNumber == num1)
            //    {
            //        while (num1 > 0) 
            //        {
            //            if (num1 % 10 == 0)
            //            {
            //                count++;
            //            }
            //            num1 /= 10;
            //        }
            //        Console.WriteLine($"reqemde =={count}== dene 0 ededi var");
            //    }

            #endregion

            #region Task 14

            //    int num1;
            //l1:
            //    Console.Write("reqemi daxil edin:");
            //    int.TryParse(Console.ReadLine(), out num1);
            //    if (num1 < 9 && num1 > 0)
            //    {
            //        int a = 10 + num1;
            //        Console.WriteLine(a);
            //    }
            //    else
            //    {
            //        goto l1;
            //    }

            #endregion

            #region Task 15

            //    int num1;
            //l1:
            //    Console.Write("reqemi daxil edin:");
            //    int.TryParse(Console.ReadLine(), out num1);
            //    switch (num1)
            //    {
            //        case < 1:
            //        case > 365:
            //            goto l1;

            //        default:
            //            Console.Write("Ay:");
            //            switch (num1)
            //            {
            //                case <= 31:
            //                    Console.WriteLine("January");
            //                    break;
            //                case <= 59:
            //                    Console.WriteLine("February");
            //                    break;
            //                case <= 90:
            //                    Console.WriteLine("March");
            //                    break;
            //                case <= 120:
            //                    Console.WriteLine("April");
            //                    break;
            //                case <= 151:
            //                    Console.WriteLine("May");
            //                    break;
            //                case <= 181:
            //                    Console.WriteLine("June");
            //                    break;
            //                case <= 212:
            //                    Console.WriteLine("July");
            //                    break;
            //                case <= 243:
            //                    Console.WriteLine("August");
            //                    break;
            //                case <= 273:
            //                    Console.WriteLine("Septenber");
            //                    break;
            //                case <= 304:
            //                    Console.WriteLine("October");
            //                    break;
            //                case <= 334:
            //                    Console.WriteLine("November");
            //                    break;
            //                case <= 365:
            //                    Console.WriteLine("December");
            //                    break;
            //            }
            //            Console.Write("Burc:");
            //            switch (num1)
            //            {
            //                case >= 356:
            //                case <= 19:
            //                    Console.WriteLine("Oğlaq");
            //                    break;
            //                case <= 49:
            //                    Console.WriteLine("Dolça");
            //                    break;
            //                case <= 79:
            //                    Console.WriteLine("Balıqlar");
            //                    break;
            //                case <= 109:
            //                    Console.WriteLine("Qoç");
            //                    break;
            //                case <= 140:
            //                    Console.WriteLine("Buğa");
            //                    break;
            //                case <= 171:
            //                    Console.WriteLine("Əkizlər");
            //                    break;
            //                case <= 203:
            //                    Console.WriteLine("Xərçəng");
            //                    break;
            //                case <= 234:
            //                    Console.WriteLine("Aslan");
            //                    break;
            //                case <= 265:
            //                    Console.WriteLine("Qız");
            //                    break;
            //                case <= 295:
            //                    Console.WriteLine("Tərəzi");
            //                    break;
            //                case <= 325:
            //                    Console.WriteLine("Əqrəb");
            //                    break;
            //                case <= 355:
            //                    Console.WriteLine("Oxatan");
            //                    break;
            //            }

            //            break;
            //    }


            #endregion

            #region Task 16

            int num1, uzunluq1;
        l1:
            Console.Write("reqemi daxil edin:");
            int.TryParse(Console.ReadLine(), out num1);
            uzunluq1 = (int)Math.Log10(num1) + 1;
            if (uzunluq1 != 6)
            {
                goto l1;
            }

            int qaliq1 = num1 % 10;
            num1 /= 10;
            int qaliq2 = num1 % 10;
            num1 /= 10;
            int qaliq3 = num1 % 10;
            num1 /= 10;
            int qaliq4 = num1 % 10;
            num1 /= 10;
            int qaliq5 = num1 % 10;
            num1 /= 10;
            int qaliq6 = num1 % 10;

            int count = 1;
            if (qaliq1 != qaliq2)
            {
                count++;
            }
            if (qaliq3 != qaliq1 && qaliq3 != qaliq2)
            {
                count++;
            }
            if (qaliq4 != qaliq1 && qaliq4 != qaliq2 && qaliq4 != qaliq3)
            {
                count++;
            }
            if (qaliq5 != qaliq1 && qaliq5 != qaliq2 && qaliq5 != qaliq3 && qaliq5 != qaliq4)
            {
                count++;
            }
            if (qaliq6 != qaliq1 && qaliq6 != qaliq2 && qaliq6 != qaliq3 && qaliq6 != qaliq4 && qaliq6 != qaliq5)
            {
                count++;
            }

            Console.WriteLine($"{count} dene unikal eded var");

            #endregion
        }
    }
}