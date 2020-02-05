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
            SingletonSensor ExampleSensor = SingletonSensor.GetInstance(0, 1);
            Console.WriteLine("Датчик {0} в {1}", ExampleSensor.GetSensorType, ExampleSensor.GetRoom);
            // у нас не получится изменить объект, так как объект уже создан 
            ExampleSensor = SingletonSensor.GetInstance(2, 3);
            Console.WriteLine("Датчик {0} в {1}", ExampleSensor.GetSensorType, ExampleSensor.GetRoom);
            // Равно как и создать второй экземпляр
            SingletonSensor ExampleSensor2 = SingletonSensor.GetInstance(1, 2);
            Console.WriteLine("Датчик {0} в {1}", ExampleSensor2.GetSensorType, ExampleSensor2.GetRoom);
            Console.ReadLine();
            Console.WriteLine();

            // демонстрация работы паттерна Abstract Factory
            Reader ExampleClient = new Reader();
            ExampleClient.ReadSignals();
            Console.ReadLine();
        }
    }
}
