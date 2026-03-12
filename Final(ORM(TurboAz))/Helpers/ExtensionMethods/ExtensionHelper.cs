using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ORM_TurboAz__.Helpers.ExtensionMethods
{
    public static class ExtensionHelper
    {
        public static void ShowErrorMessage(this string txt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(txt);
            Console.ResetColor();
        }

        public static string GetFullDelimiter(this char txt)
        {
            string text = new(txt, Console.WindowWidth);
            return text;
        }
    }
}
