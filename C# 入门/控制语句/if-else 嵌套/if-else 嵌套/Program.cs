﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_嵌套
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("请输入第一个数:");
            number1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("请输入第二个数:");
            number2 = Convert.ToInt16(Console.ReadLine());
            if(number1==number2)
            {
                Console.WriteLine("两数相等");
            }
            if(number1!=number2)
            {
                if(number1>number2)
                {
                    Console.WriteLine("numbe1>numbwe2");
                }
                if(number1<number2)
                {
                    Console.WriteLine("number1<number2");
                }
            }

            Console.ReadLine();
        }
    }
}
