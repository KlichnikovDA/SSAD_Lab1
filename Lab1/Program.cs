using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // демонстрация работы паттерна Singleton
            House ExampleHouse = House.getInstance();
            Console.WriteLine("{0}; {1} комнат", House.GetAddress, House.GetRooms);
            // у нас не получится изменить дом, так как объект уже создан    
            ExampleHouse = House.getInstance();
            Console.WriteLine("{0}; {1} комнат", House.GetAddress, House.GetRooms);
            Console.ReadLine();
            Console.WriteLine();

            // демонстрация работы паттерна Abstract Factory
            Sensor S1 = new Sensor(0, 0);
            Sensor S2 = new Sensor(2, 1);

            Signal SigVal = (Signal)S1.CreateProduct();
            SigVal.ProductAction();
            Console.ReadLine();
            SigVal = (Signal)S1.CreateProduct();
            SigVal.ProductAction();
            Console.ReadLine();
            SigVal = (Signal)S2.CreateProduct();
            SigVal.ProductAction();
            Console.ReadLine();
            SigVal = (Signal)S2.CreateProduct();
            SigVal.ProductAction();
            Console.ReadLine();
        }
    }
}
