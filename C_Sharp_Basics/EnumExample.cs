using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics
{
    public class EnumExample
    {
        public enum Season { WINTER, SPRING,SUMMER, FALL}

        public static void _enum()
        {
            int x = (int)Season.WINTER;
            int y = (int)Season.SUMMER;

            Console.WriteLine("WINTER = {0}", x);
            Console.WriteLine("SUMMER = {0}", y);
        }
    }
}
