﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承与多态性_继承2
{
    public class Baseclass
    {
        public void show()
        {
            Console.WriteLine("这是基类中的内容");
        }
    }

    public class Derivedclass:Baseclass
    {
        public void shownew()
        {
            Console.WriteLine("这是第一个派生类中的内容");
        }
    }
    
    public class Thirdclass:Derivedclass
    {
        public void  showthird()
        {
            Console.WriteLine("这是第二个派生类中的内容");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thirdclass aclass = new Thirdclass();
            aclass.show();
            aclass.shownew();
            aclass.showthird();
            Console.ReadLine();
        }
    }
}
