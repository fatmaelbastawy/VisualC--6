// See https://aka.ms/new-console-template for more information
using Lab8_Extensionmethod;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {


        int number = 7568;
        Console.WriteLine(number);
        //int temp;int rev = 0;
        //while (number != 0)
        //{
        //    temp = number % 10;
        //    rev = (rev * 10) + temp;
        //    number = number / 10;
        //}
        Console.WriteLine(number.Reversenum());
        Console.WriteLine(number.NoOfDigit());
        string str = "bg!hg-hj/&jg+g_k#";
        Console.WriteLine(str.RemoveSpecialChar());

        //int max = int.MinValue;
        //Console.WriteLine(max);
       IEnumerable <int> mylist = new List<int>() { 7, 12, 30, 5 };

        Console.WriteLine(mylist.MaxNum());


   




        //string newstr = string.Empty;
        //for (int i = 0; i < str.Length; i++)
        //{
        //    switch (str[i])
        //    {

        //        case '!':
        //        case '-':
        //        case '/':
        //        case '+':
        //        case '_':
        //        case '#':
        //            newstr += "";
        //            break;
        //        default:
        //            newstr += str[i];
        //            break;
        //    }
        //}
        //Console.WriteLine(newstr);
    }



        
}


