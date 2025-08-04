using static System.Net.Mime.MediaTypeNames;

namespace Assignment_5._1._1
{
    //Given an integer x, return true if x is a palindrome, and false otherwise.
    //Cannot convert to a string, must keep data type int.
    //Status: Complete
    internal class Program
    {
        static void Main(string[] args)
        {
            int test1 = 121;
            int test2 = 4321;
            int test3 = -121;

            //if (Int32.IsNegative(test1))
            TestPalindrome(test1);
            TestPalindrome(test2);
            TestPalindrome(test3);
            

        }

        static int ReverseInteger(int num)
        {
            int reversedNum = 0;
            while (num > 0)
            {
                reversedNum = (reversedNum * 10) + (num % 10);
                num /= 10;
            }
            //Console.WriteLine(reversedNum);
            return reversedNum;
        }

        static void TestPalindrome(int input)
        {
            Console.Write($"Testing is {input} is a Palindrome: ");
            if (input == ReverseInteger(input))
            { Console.WriteLine("True"); }
            else
            { Console.WriteLine("False"); }
        }
        
    }
}
