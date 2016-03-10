using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    //顾客充当客户端，调用简单工厂生产对象

    class Customer
    {
        static void GetFood()
        {
            // 客户想点一个西红柿炒蛋        
            Food food1 = SimpleFactory.CreateFood("西红柿炒蛋");
            food1.Print();

            // 客户想点一个土豆肉丝
            Food food2 = SimpleFactory.CreateFood("土豆肉丝");
            food2.Print();

            Console.Read();
        }
    }

    //菜的抽象类
    public abstract class Food
    {
        public abstract void Print();
    }

    //西红柿鸡蛋
    public class TomatoScrambledEggs : Food
    {
        public override void Print()
        {
            Console.WriteLine("西红柿炒鸡蛋");
        }
    }

    //土豆肉丝
    public class ShreddedPorkWithPotatoes : Food
    {
        public override void Print()
        {
            Console.WriteLine("土豆肉丝");
        }
    }
    
    //简单工厂类，负责生产菜的实例
    public class SimpleFactory
    {
        public static Food CreateFood(string type)
        {
            Food food = null;
            if (type.Equals("土豆肉丝"))
            {
                food = new ShreddedPorkWithPotatoes();
            }
            if (type.Equals("西红柿鸡蛋"))
            {
                food = new TomatoScrambledEggs();
            }
            return food;
        }
    }
}
