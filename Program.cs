using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Operations System
{
    internal class Program
    {
        public class Operations
        {
            public void Addition()
            {
                double sum = 0;
                Console.Write("\nEnter the number of numbers : ");
                int nums = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------");
                for (int i = 0; i < nums; i++)
                {
                    Console.WriteLine($"Enter the number {i + 1}");
                    double number = double.Parse(Console.ReadLine());
                    sum += number;
                }
                Console.WriteLine($"----------------------\nSum of {nums} numbers : {sum}\n----------------------\n");
            }
            public void Subtraction()
            {
                double sub = 0;
                Console.Write("\nEnter the number of numbers : ");
                double nums = double.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------");
                Console.WriteLine("Enter the number 1 ");
                double num1 = double.Parse(Console.ReadLine());
                for (int i = 0; i < nums - 1; i++)
                {
                    Console.WriteLine($"Enter the number {i + 2}");
                    double num = double.Parse(Console.ReadLine());
                    sub -= num;
                }
                Console.WriteLine($"---------------------\nSub of numbers : {sub + num1}\n---------------------\n");
            }
            public void Multiplication()
            {
                int mult = 1;
                Console.Write("\nEnter the number of numbers : ");
                int nums = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------");
                for (int i = 1; i <= nums; i++)
                {
                    Console.WriteLine($"Enter the number {i}");
                    int number = int.Parse(Console.ReadLine());
                    mult *= number;
                }
                Console.WriteLine($"----------------------\n Multiplication of {nums} numbers : {mult}\n----------------------\n");
            }
            public void Division()
            {
                Console.WriteLine("\nEnter the first number");
                double number1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                double number2 = double.Parse(Console.ReadLine());
                double div = number1 / number2;
                Console.WriteLine($"----------------------\n Result of {number1} / {number2} = {div}\n----------------------\n");
            }
            public void Modulus()
            {
                Console.WriteLine("\nEnter the first number");
                double number1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                double number2 = double.Parse(Console.ReadLine());
                double modulus = number1 % number2;
                Console.WriteLine($"----------------------\n Result of {number1} % {number2} = {modulus}\n----------------------\n");
            }
            public void squaring()
            {
                Console.WriteLine("\nEnter the number");
                double number = double.Parse(Console.ReadLine());
                double square = number * number;
                Console.WriteLine($"\n----------------------\nResult of {number}^2 = {square}\n----------------------");
            }
            public void sqrt()
            {
                Console.WriteLine("Enter the number");
                double number = int.Parse(Console.ReadLine());
                double result = Math.Sqrt(number);
                Console.WriteLine($"\n----------------------\nResult of Sqrt of {number} = {result}\n----------------------");
            }
            public void testing()
            {
                Console.WriteLine("\nEnter the number");
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine($"\n----------------------\nThe {number} is even number\n----------------------\n");
                }
                else
                {
                    Console.WriteLine($"\n----------------------\nThe {number} is odd number\n----------------------\n");
                }
            }
            public void fact()
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());
                int Fact = 1;
                int i = 0;
                if (num == 0)
                {
                    Console.WriteLine(0);
                }
                else if (num == 1)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    for (i = num; i >= 1; i--)
                    {
                        Fact *= i;
                    }
                    Console.WriteLine("---------------------------\nthe fact number of {0} is {1}\n---------------------------", num, Fact);
                }
            }
            public void power()
            {
                Console.WriteLine("Enter the number");
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the power");
                double pow = double.Parse(Console.ReadLine());
                double result = Math.Pow(number, pow);
                Console.WriteLine($"---------------------------\nthe result of {number} ^ {pow} is {result}\n---------------------------");
            }
            //public void prime()
            //{
            //    Console.WriteLine("Enter  a number");
            //    int num = int.Parse(Console.ReadLine());
            //    if (num < 2)
            //    {
            //        Console.WriteLine("Invalid Entry !!!");
            //        return;
            //    }
            //    for (int i = 2; i < num / 2; i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            Console.WriteLine($"{num} is not prime ");
            //            return;
            //        }
            //    }
            //    Console.WriteLine($"------------------------\n{num} is prime number\n------------------------\n ");
            //}
            public void max_min()
            {
                Console.WriteLine("Enter the size of numbers ");
                int[] arr = new int[Convert.ToInt32(Console.ReadLine())];

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(" enter the number " + (i + 1));
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                int max = arr[0];
                int min = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                Console.WriteLine($"\n---------------------\nthe max number is {max}\n---------------------");
                Console.WriteLine($"---------------------\nthe max number is {min}\n---------------------\n");
            }
            public void table_item()
            {
                int number;
                do
                {
                    Console.WriteLine("\nEnter the type of data\n1- Integers\n2- Strings\n3- Exit");
                    Console.Write("Choose a number : ");
                    number = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("\nEnter the number of numbers");
                            int numbers = int.Parse(Console.ReadLine());
                            int[] arr = new int[numbers];
                            for (int j = 0; j < numbers; j++)
                            {
                                Console.WriteLine($"Enter the number{j + 1}");
                                arr[j] = int.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("====================\nTable of numbers  ||\n====================");

                            for (int j = 0; j < numbers; j++)
                            {
                                Console.WriteLine($"-  {arr[j]}               |");
                            }
                            Console.WriteLine("--------------------");
                            break;
                        case 2:
                            int add = -1;
                            string[] str = new string[50];
                            Console.Write("Enter the numbers : ");
                            int numBooks = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            for (int i = 0; i < numBooks; i++)
                            {
                                Console.Write($"Enter the string {i + 1}  :  ");
                                string word = Console.ReadLine();
                                str[i] = word;
                                add++;
                            }
                            Console.WriteLine("\n====================\nTable of numbers  ||\n====================");
                            for (int i = 0; i <= add; i++)
                            {
                                if (str[i] != null)
                                {
                                    Console.WriteLine($"- {str[i]}");
                                }
                            }
                            Console.Write("--------------------");
                            Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine("______________\nWrong number\n--------------");
                            break;
                    }
                }
                while (number != 3);
            }
            public void Determenant()
            {
                Console.WriteLine("\nDetermine whether 2D or 3D\n------------------------------\n1- 2D\n2- 3D\n");
                Console.Write("Option : ");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        int element1, element2, element3, element4, result;
                        Console.WriteLine("\n------------------------\nEnter the first row\n------------------------\nFirst number  :  ");
                        element1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Second number : ");
                        element2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n------------------------\nEnter the second row\n------------------------\nFirst number :  ");
                        element3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Second number : ");
                        element4 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        result = element1 * element4 - element2 * element3;
                        Console.WriteLine(" | " + element1 + "   " + element2 + " | ");
                        Console.WriteLine(" | " + element3 + "   " + element4 + " | ");
                        Console.WriteLine($"\n----------------\n result  =  {result}\n----------------");
                        break;
                    case 2:
                      //  int Result;
                        Console.WriteLine("\n------------------------\nEnter the first row\n------------------------\nFirst number  :  ");
                        int Element1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Second number : ");
                        int Element2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Third number : ");
                        int Element3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n------------------------\nEnter the second row\n------------------------\nFirst number :  ");
                        int Element4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Second number : ");
                        int Element5 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Third number : ");
                        int Element6 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n------------------------\nEnter the second row\n------------------------\nFirst number :  ");
                        int Element7 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Second number : ");
                        int Element8 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Third number : ");
                        int Element9 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        int x = Element1 * (Element5 * Element9 - Element6 * Element8);
                        int y = -Element2 * (Element4 * Element9 - Element6 * Element7);
                        int z = Element3 * (Element4 * Element8 - Element5 * Element7);
                        Console.WriteLine(" | " + Element1 + "   " + Element2 + "   " + Element3 + " | ");
                        Console.WriteLine(" | " + Element4 + "   " + Element5 + "   " + Element6 + " | ");
                        Console.WriteLine(" | " + Element7 + "   " + Element8 + "   " + Element9 + " | ");
                        Console.WriteLine($"\n----------------\n result  =  {x + y + z}\n----------------");
                        break;
                    default:
                        Console.WriteLine($"\n----------------\n Wrong number\n----------------");
                        break;
                }
            }
            public void Convering()
            {
                Console.WriteLine("\nDetermine type that you want\n==============================\n1- Decimal to Binary\n2- Binary to Decimal\n3- Decimal to Hexa_Decimal");
                Console.Write("\n------------------------------\n\nOption : ");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine("\n------------------------------");
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the number to convert");
                        int number = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        int[] arr = new int[20];
                        int i = 0;
                        for (i = 0; number > 0; i++)
                        {
                            arr[i] = number % 2;
                            number = number / 2;
                        }
                        Console.Write("-------------------\nbinary is :");
                        for (i = i - 1; i >= 0; i--)
                        {
                            Console.Write(arr[i]);
                        }
                        Console.WriteLine("\n-------------------");
                        break;
                    case 2:
                        Console.WriteLine("Enter the number to convert");
                        string bin = Console.ReadLine();
                        string revBin = "";
                        for (int j = bin.Length - 1; j >= 0; j--)
                        {
                            revBin += bin[j];
                        }
                        double a = 0.0;
                        for (int j = 0; j < revBin.Length; j++)
                        {
                            int y = int.Parse(revBin[j].ToString());
                            a += y * Math.Pow(2, j);
                        }
                        Console.WriteLine("-------------------\nThe result is " + a + "\n-------------------");
                        break;
                    case 3:
                        string bin1 = "";
                        Console.WriteLine("enter the decimal number");
                        int n = int.Parse(Console.ReadLine());
                        int x = 0;
                        for (x = 0; n > 0; x++)
                        {
                            int rem = n % 16;
                            n = n / 16;
                            string hex = rem.ToString();
                            if (rem > 9)
                            {
                                if (rem == 10)
                                {
                                    hex = "A";
                                }
                                else if (rem == 11)
                                {
                                    hex = "B";
                                }
                                else if (rem == 12)
                                {
                                    hex = "C";
                                }
                                else if (rem == 13)
                                {
                                    hex = "D";
                                }
                                else if (rem == 14)
                                {
                                    hex = "E";
                                }
                                else if (rem == 15)
                                {
                                    hex = "F";
                                }
                            }
                            bin1 += hex;
                        }
                        string rev = "";
                        for (x = bin1.Length - 1; x >= 0; x--)
                        {
                            rev += bin1[x];
                        }
                        Console.WriteLine("-------------------\nThe result is " + rev + "\n-------------------");
                        break;
                    default:
                        Console.WriteLine($"\n----------------\n Wrong number\n----------------");
                        break;
                }
            }
        }
        public class OperationsStrings
        {
            public void Add_String()
            {
                Console.WriteLine("Enter the size");
                int size = int.Parse(Console.ReadLine());
                string result = "";
                string[] arr = new string[size];
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"\nEnter the string {i + 1}");
                    arr[i] = Console.ReadLine();
                }
                for (int i = 0; i < size; i++)
                {
                    result += arr[i];
                }
                Console.WriteLine(result);
                Console.WriteLine("------------------------");
            }
            public void Compare_String()
            {
                Console.WriteLine("\nEnter the First_String");
                String First_String = Console.ReadLine();
                Console.WriteLine("Enter the Second_String");
                String Second_String = Console.ReadLine();
                if (First_String.Length == Second_String.Length)
                {
                    if (First_String == Second_String)
                    {
                        Console.WriteLine("\n-------------------------");
                        Console.WriteLine("The two strings are equal");
                        Console.WriteLine("-------------------------");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("The two strings are not equal");
                        Console.WriteLine("--------------------------------------------");
                        for (int i = 0; i < First_String.Length; i++)
                        {
                            if (First_String[i] == Second_String[i])
                            {
                                Console.WriteLine($"The caractar {i + 1} is similar (Charactar {First_String[i] + " = " + "Charactar " + Second_String[i]})");
                            }
                            if (First_String[i] != Second_String[i])
                            {
                                Console.WriteLine($"The caractar {i + 1} is difference (Charactar {First_String[i] + " != " + "Charactar " + Second_String[i]})");
                            }
                        }
                        Console.WriteLine("--------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("-----------------------------------------");
                    { Console.WriteLine("\nThe two strings are not the same length\n"); }
                    Console.WriteLine("-----------------------------------------");
                }

            }
            public void Reverse()
            {
                Console.WriteLine("Enter a string");
                string str = Console.ReadLine();
                string reverse = "";
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    reverse += str[i];
                }
                Console.WriteLine(reverse);
            }
            public void Remove_Dublicate()
            {
                Console.WriteLine("\nenter the string");
                string name = Console.ReadLine();
                string Name = "";
                for (int i = 0; i < name.Length; i++)
                {
                    if (!(Name.Contains(name[i])))
                    {
                        Name = Name + name[i];
                    }
                }
                Console.WriteLine("-------------------\nThe result is " + Name + "\n-------------------");
            }
            public void Ispalandrome()
            {
                Console.WriteLine("enter the text ");
                string word = Console.ReadLine();
                string reverse = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverse = reverse + word[i];
                }
                if (word == reverse)
                {
                    Console.WriteLine("\n--------------------------\n {0} is palandrome\n--------------------------\n", word);
                }
                else
                    Console.WriteLine($"\n-----------------------------\n {word} is not palandrome\n-----------------------------\n");
            }
            public void Alphapet()
            {
                Console.WriteLine("enter the string");
                string word = Console.ReadLine();
                Console.WriteLine();
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] >= 'a' && word[i] <= 'z' || word[i] >= 'A' && word[i] <= 'Z')
                    {
                        if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'u' || word[i] == 'o'
                            || word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'U' || word[i] == 'O')
                        {
                            Console.WriteLine($"-----------------\n{word[i]} is a vowel");
                        }
                        else
                        {
                            Console.WriteLine($"-----------------\n{word[i]} is a Consonant");
                        }
                    }
                    else
                        Console.WriteLine($"-----------------\n{word[i]} is not alphabet");
                }
                Console.WriteLine("-----------------");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                int option = 0;
                int option2 = 0;
                int string_choice = 0;
                do
                {
                    Console.WriteLine("\n===== Main Menu =====\n\n1- Math proccesses\n\n2- String proccesses\n\n3- Exit");
                    Console.WriteLine("\n---------------------\n");
                    Console.Write("Option :  ");
                    option2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n---------------------");
                    Console.Clear();
                    if (option2 == 1)
                    {
                        do
                        {
                            Console.WriteLine(
                                   "\n- Select the operation\n\n" +
                                    "======================\n" +
                                    "1-  Addition\n" +
                                    "2-  Subtraction\n" +
                                    "3-  Multiplication\n" +
                                    "4-  Divition\n" +
                                    "5-  Modulus\n" +
                                    "6-  Squaring\n" +
                                    "7-  Square root\n" +
                                    "8-  Even or not\n" +
                                    "9-  Factorial\n" +
                                    "10- Power\n" +
                                    //"11- prime\n" +
                                    "11- Max and Min of Array\n" +
                                    "12- Table of content\n" +
                                    "13- Determinant\n" +
                                    "14- Converting\n" +
                                    "15- Exit\n" +
                                    "---------------------"
                                    );
                            Console.Write("Option : ");
                            try
                            {
                                option = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e) { Console.WriteLine(e.Message); }
                            Console.WriteLine("---------------------");
                            switch (option)
                            {
                                case 1:
                                    Operations obj1 = new Operations();
                                    obj1.Addition();
                                    break;
                                case 2:
                                    Operations obj2 = new Operations();
                                    obj2.Subtraction();
                                    break;
                                case 3:
                                    Operations obj3 = new Operations();
                                    obj3.Multiplication();
                                    break;
                                case 4:
                                    Operations obj4 = new Operations();
                                    obj4.Division();
                                    break;
                                case 5:
                                    Operations obj5 = new Operations();
                                    obj5.Modulus();
                                    break;
                                case 6:
                                    Operations obj6 = new Operations();
                                    obj6.squaring();
                                    break;
                                case 7:
                                    Operations obj7 = new Operations();
                                    obj7.sqrt();
                                    break;
                                case 8:
                                    Operations obj8 = new Operations();
                                    obj8.testing();
                                    break;
                                case 9:
                                    Operations obj9 = new Operations();
                                    obj9.fact();
                                    break;
                                case 10:
                                    Operations obj10 = new Operations();
                                    obj10.power();
                                    break;
                                //case 11:
                                //    Operations obj11 = new Operations();
                                //    obj11.prime();
                                //    break;
                                case 11:
                                    Operations obj12 = new Operations();
                                    obj12.max_min();
                                    break;
                                case 12:
                                    Operations obj13 = new Operations();
                                    obj13.table_item();
                                    break;
                                case 13:
                                    Operations obj14 = new Operations();
                                    obj14.Determenant();
                                    break;
                                case 14:
                                    Operations obj15 = new Operations();
                                    obj15.Convering();
                                    break;
                                case 15:
                                    break;
                                default:
                                    Console.WriteLine("\nError , Number is out of range");
                                    break;
                            }
                        } while (option != 15);
                    }
                    else if (option2 == 2)
                    {
                        do
                        {
                            Console.WriteLine("\n ==============================\n- Enter the operation you want :\n ==============================\n\n" +
                                "1- Add the two strings  \n2- Compare the two strings" +
                                  "\n3- Reverse string \n4- Remove Dublicate \n5- Is Palandrome \n6- Alphapet \n7- Return to Page");
                            Console.Write("\n-----------------------\n\nOption :  ");
                            string_choice = int.Parse(Console.ReadLine());
                            Console.WriteLine("\n-----------------------\n");
                            switch (string_choice)
                            {
                                case 1:
                                    OperationsStrings str1 = new OperationsStrings();
                                    str1.Add_String();
                                    break;
                                case 2:
                                    OperationsStrings str2 = new OperationsStrings();
                                    str2.Compare_String();
                                    break;
                                case 3:
                                    OperationsStrings str3 = new OperationsStrings();
                                    str3.Reverse();
                                    break;
                                case 4:
                                    OperationsStrings str4 = new OperationsStrings();
                                    str4.Remove_Dublicate();
                                    break;
                                case 5:
                                    OperationsStrings str5 = new OperationsStrings();
                                    str5.Ispalandrome();
                                    break;
                                case 6:
                                    OperationsStrings str6 = new OperationsStrings();
                                    str6.Alphapet();
                                    break;
                                case 7:
                                    break;
                                default:
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Please Enter Number between 1 to 7");
                                    Console.WriteLine("----------------------------------");
                                    break;
                            }
                        } while (string_choice != 7);
                    }
                }
                while (option2 != 3);
            }
            catch (Exception e) { Console.WriteLine("\n------------\nInvalid Data\n------------\n"); }
        }
    }
}
