using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Extensionmethod
{
     static class Extension
    {
        public static int Reversenum(this int number)
        {
             int temp; int rev = 0;
            while (number != 0)
            {
                temp = number % 10;
                rev = (rev * 10) + temp;
                number = number / 10;
            }
            return  rev  ;
        }



        public static int NoOfDigit(this int number)
        {
            int temp;int count = 0;
            while (number > 0)
            {
                temp = number % 10;
                count++;
                number = number / 10;
                
            }
            return count;
        }


        public static string RemoveSpecialChar(this string str)
        {
            //string newstr = string.Empty;
            string newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {

                    case '!':
                    case '-':
                    case '/':
                    case '+':
                    case '_':
                    case '#':
                        newstr += "";
                        break;
                    default:
                        newstr += str[i];
                        break;
                }
            }
            return newstr;
        }





        public static int MaxNum(this IEnumerable<int> list)
        //,Predicate<int>predicate
        {

            //int max = int.MinValue;
            int max = 0;
            foreach (var item in list)
            {
                if (max < item)
                {
                    max = item;
                    //Console.WriteLine(item);
                }

            }
            return max;

        }

        private static bool Predicate<T>(int item)
        {
            throw new NotImplementedException();
        }
    }
}
