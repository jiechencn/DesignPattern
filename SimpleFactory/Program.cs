using System;

namespace SimpleFactory
{
    /// <summary>
    /// 简单工厂类模式的组成：
    /// 一个工厂类
    /// 一个要被创建实例的父类
    /// 这个父类的多个多个子类
    /// 
    /// 具体要创建哪一种子类，是根据传给工厂类的的参数标识（比如字符串）在运行时决定的。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IFish littleFish = FishFactory.BuildFish("little");
            littleFish.Swim();

            IFish bigFish = FishFactory.BuildFish("big");
            bigFish.Swim();
        }
    }
}
