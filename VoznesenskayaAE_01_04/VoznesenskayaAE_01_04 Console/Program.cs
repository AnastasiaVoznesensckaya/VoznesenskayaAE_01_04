using System;
using VoznesenskayaAE_01_04;
namespace VoznesenskayaAE_01_04_Console
{
    class Program
    {
        static void Main (string[] args)
        {
            //Создаем экземпляр базового класса
            Computer computer = new Computer("Test", 4.3, 10000);
            computer.Calculate();
            Console.WriteLine(computer.Print());
            //Создаем экземпляр класса потомка
            ChildClass computer2 = new ChildClass("Test1", 4.6, 1000, 1000);
            computer2.Calculate();
            Console.WriteLine(computer2.Print());
            
        }
    }
}
