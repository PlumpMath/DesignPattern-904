using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMathod
{
    //以绝味鸭脖在上海和南昌两地的工厂为例

    class Client
    {
        static void Main(string[] args)
        {
            AbstractFactory nanChangFactory = new NacChangFactory();
            YaBo nanChangYaBo = nanChangFactory.CreateYaBo();
            YaJia nanChangYaJia = nanChangFactory.CreateYaJia();
            nanChangYaBo.Print();
            nanChangYaJia.Print();

            AbstractFactory shangHaiFactory = new ShangHaiFactory();
            YaBo shangHaiYaBo = shangHaiFactory.CreateYaBo();
            YaJia shangHaiYaJia = shangHaiFactory.CreateYaJia();
            shangHaiYaBo.Print();
            shangHaiYaJia.Print();
        }
    }


    //抽象工厂类，提供两种不同的创建接口
    class AbstractFactory
    {
        //抽象工厂提供创建一系列产品的接口
        public abstract YaBo CreateYaBo();
        public abstract YaJia CreateYaJia();
    }

    //南昌工厂
    public class NacChangFactory : AbstractFactory
    {
        public override YaBo CreateYaBo()
        {
            return new NanChangYaBo();
        }

        public override YaJia CreateYaJia()
        {
            return new NanChangYaJia();
        }
    }

    /// 上海绝味工厂负责制作上海的鸭脖和鸭架
     public class ShangHaiFactory : AbstractFactory
     {
        // 制作上海鸭脖
         public override YaBo CreateYaBo()
         {
            return new ShangHaiYaBo();
         }
        // 制作上海鸭架
         public override YaJia CreateYaJia()
         {
             return new ShangHaiYaJia();
         }
     }

    //鸭脖抽象类
    public abstract class YaBo
    {
        public abstract void Print();
    }

    //鸭架抽象类
    public abstract class YaJia
    {
        public abstract void Print();
    }

    //南昌鸭脖类
    public class NanChangYaBo : YaBo
    {
        public override void Print()
        {
            Console.WriteLine("南昌的鸭脖");
        }
    }

    //上海鸭架类
    public class NanChangYaJia : YaJia
    {
        public override void Print()
        {
            Console.WriteLine("南昌的鸭架");
        }
    }

    //上海鸭脖类
    public class ShangHaiYaBo : YaBo
    {
        public override void Print()
        {
            Console.WriteLine("上海的鸭脖");
        }
    }

    //上海鸭架类
    public class ShangHaiYaJia : YaJia
    {
        public override void Print()
        {
            Console.WriteLine("上海的鸭架");
        }
    }
}
