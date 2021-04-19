using System;

namespace WichPart
{
    class Program
    {
        static string wichPart(String source)
        {
            string result="";
            string am = "ABCDEFGHIGKLMabcdefghigklm";
            string nz = "NOPQRSTUVWXYZnopqrstuvwxyz";

            foreach (var item in source)
                if (am.Contains(item)) result += "o";
                else if (nz.Contains(item)) result += "t";
                else result += ".";
            {

            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(wichPart("abszzzXXCCDDDaaAAEErrEp>KHTEdfldkmf_"));
        }
    }
}
