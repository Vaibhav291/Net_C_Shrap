using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics
{
    public class Example
    {
        public void Thrd1()
        {
            for (char i = 'a'; i < 'g'; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }
    }
    public class Threads_
    {
        
        public static void Main(string[] args)
        {
            Example example = new Example();
            Thread x = new Thread(new ThreadStart(example.Thrd1));
            Thread y = new Thread(new ThreadStart(example.Thrd1));

            x.Start();  
            y.Start();
        }
    }
}
