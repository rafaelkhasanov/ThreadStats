using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadStats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primary Thread stats");

            //Получить имя текущего потока
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "ThePrimaryThread";
            //Показать детали обслуживающего домена приложения и контекста
            Console.WriteLine($"Name of current AppDomain: {Thread.GetDomain().FriendlyName}");
            Console.WriteLine($"Id of current Context: {Thread.CurrentContext.ContextID}");
            //Вывести некоторую статистику о текущем потоке
            Console.WriteLine($"Thread Name: {primaryThread.Name}");
            Console.WriteLine($"Has thread started?: {primaryThread.IsAlive}");
            Console.WriteLine($"Priority Level: {primaryThread.Priority}");
            Console.WriteLine($"Thread State: {primaryThread.ThreadState}");
            Console.ReadLine();
        }
    }
}
