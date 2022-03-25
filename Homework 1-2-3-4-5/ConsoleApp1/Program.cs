using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            //string words = Console.ReadLine();
            //ChangeWords (words);
          
            #endregion

            #region task 2.1
            //string text1 = Console.ReadLine();
            //CheckContainDigit(text1);
            #endregion

            #region task 2.2
            //string text2 = Console.ReadLine();
            //CheckContainUpper(text2);
            #endregion

            #region task 2.3
            //string text3 = Console.ReadLine();
            //CheckContainLower(text3);
            #endregion

            #region task 3

            //string text4 = Console.ReadLine();
            //FindFirstWord(text4);
            #endregion

            #region task 4
            //string text4 = Console.ReadLine();
            //CheckWorsdAndLetters(text4);
            #endregion

            #region task 5


            //Console.WriteLine( "Nece eded daxil olunacaq:");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int []numbers =new int[size];
            //Console.WriteLine("Arrayi daxil edin:");
            //for (int i = 0; i < size; i++) { 
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Elave olunacaq reqemi daxil edin:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" \n =============Yeni array============\n");
            //foreach ( var item in AddNewNum(ref numbers, num))
            //{
               
            //    Console.WriteLine(item);
           // }

            #endregion
        }


        static void ChangeWords(string words)
        {
            string[] words2 = words.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            words = string.Join(" ", words2);
            Console.WriteLine(words);
        }

        static void CheckContainDigit(string str)
        {
            bool isNumber = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    isNumber = true;
                    break;
                }
            }

            if (isNumber)
            {
                Console.WriteLine("Reqem var.");
            }
            else
            {
                Console.WriteLine("Reqem yoxdur.");
            }


        }
        static void CheckContainUpper(string str)
        {
            bool isNumber = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    isNumber = true;
                    break;
                }
            }

            if (isNumber)
            {
                Console.WriteLine("Bouk herf var.");
            }
            else
            {
                Console.WriteLine("Boyuk herf  yoxdur.");
            }

            
        }
        static void CheckContainLower(string str)
        {
            bool isNumber = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i]))
                {
                    isNumber = true;
                    break;
                }
            }

            if (isNumber)
            {
                Console.WriteLine("Kicik herf var.");
            }
            else
            {
                Console.WriteLine("Kicik herf  yoxdur.");
            }
        }
        static void FindFirstWord(string str)
        {
            string [] strig2 = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
             string word = strig2[0];
            Console.WriteLine(word);
        }

        static void CheckWorsdAndLetters(string str)
        {
            string[] str2 = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (str2.Length == 2)
            {

                if (char.IsUpper(str2[0][0]) && char.IsUpper(str2[1][0]))
                {
                    Console.WriteLine("Boyuk herfle baslayan 2 soz var .");

                }
                else
                {
                    Console.WriteLine("2 soz var amma 2-side boyuk herfle baslamir .");
                }
            } 
            else
            {
                Console.WriteLine( " 2 soz yoxdur.");
            }
        }

        static int [] AddNewNum ( ref int [] arr , int num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;
            return arr;


        }
    }

}
