using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        //定义一个静态变量来保存类的实例
        private static Singleton uniqueInstance;

        //定义一个标识确保线程同步
        private static readonly object locker = new object();

        //定义私有构造函数，外界不能访问
        private Singleton()
        {

        }

        //定义公有方法提供一个全局访问点，获取类的实例
        public static Singleton GetInstance()
        {
            //没必要在锁定后再判断，避免额外的开销
            if (uniqueInstance == null)
            {
                //用互斥锁的方式来确保该公有方法一次只能被一个线程运行
                lock (locker)
                {
                    //如果类不存在，则创建，否则直接返回
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new Singleton();
                    }
                }
            }
            return uniqueInstance;
        }
    }
}
