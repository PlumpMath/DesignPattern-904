using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMathod;

namespace AbstractFactory
{
    public abstract class Food
    {
        // 输出点了什么菜
        public abstract void Print();
    }

    /// <summary>
    /// 西红柿炒鸡蛋这道菜
    /// </summary>
    public class TomatoScrambledEggs : Food
    {
        public override void Print()
        {
            Console.WriteLine("西红柿炒蛋好了！");
        }
    }

    /// <summary>
    /// 土豆肉丝这道菜
    /// </summary>
    public class ShreddedPorkWithPotatoes : Food
    {
        public override void Print()
        {
            Console.WriteLine("土豆肉丝好了");
        }
    }

    class FactoryMathod
    {

    }

    //抽象工厂类
    public abstract class Creator
    {
        //工厂方法
        public abstract Food CreateFoodFactory();
    }

    //西红柿炒蛋工厂类
    public class TomatoScrambledEggsFactory : Creator
    {
        //负责创建西红柿鸡蛋这道菜
        public override Food CreateFoodFactory()
        {
            return new TomatoScrambledEggs();
        }
    }

    //土豆肉丝工厂类
    public class ShreddedPorkWithPotatoesFactory : Creator
    {
        //负责创建土豆肉丝这道菜
        public override Food CreateFoodFactory()
        {
            return new ShreddedPorkWithPotatoes();
        }
    }


    //肉末茄子
    public class MincedMeatEggplant : Food
    {
        public override void Print()
        {
            Console.WriteLine("肉末茄子好了");
        }
    }

    public class MincedMeatEggplantFactory : Creator
    {
        /// 负责创建肉末茄子这道菜
        public override Food CreateFoddFactory()
        {
            return new MincedMeatEggplant();
        }
    }

    //调用说明
    class Client
    {
        static void CreateFood()
        {
            Creator shreddedPorkWithPotatoesFactory = new ShreddedPorkWithPotatoesFactory();
            Creator tomatoScrambledEggsFactory = new TomatoScrambledEggsFactory();

            // 开始做西红柿炒蛋
            Food tomatoScrambleEggs = tomatoScrambledEggsFactory.CreateFoodFactory();
            tomatoScrambleEggs.Print();

            //开始做土豆肉丝
            Food shreddedPorkWithPotatoes = shreddedPorkWithPotatoesFactory.CreateFoodFactory();
            shreddedPorkWithPotatoes.Print();

            // 如果客户又想点肉末茄子了
            // 再另外初始化一个肉末茄子工厂
            Creator minceMeatEggplantFactor = new MincedMeatEggplantFactory();

            // 利用肉末茄子工厂来创建肉末茄子这道菜
            Food minceMeatEggplant = minceMeatEggplantFactor.CreateFoodFactory();
            minceMeatEggplant.Print();
        }

    }
}
