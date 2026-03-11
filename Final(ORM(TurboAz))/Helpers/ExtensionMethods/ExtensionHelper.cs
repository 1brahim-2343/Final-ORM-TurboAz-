using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ORM_TurboAz__.Helpers.ExtensionMethods
{
    public static class ExtensionHelper
    {
        public static void ShowMessage(this string txt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(txt);
        }
    }
}
