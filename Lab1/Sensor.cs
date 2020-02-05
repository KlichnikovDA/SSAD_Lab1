using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    // Конкретные фабрики
    abstract class SensorFactory: AbstractFactory
    {
        protected Places WhereInstalled { get; set; }
        protected Random rnd;
    }

    class TemperatureSensor: SensorFactory
    {
        public TemperatureSensor(int RoomNumber, Random rand)
        {
            WhereInstalled = (Places)RoomNumber;
            rnd = rand;
        }

        public override AbstractProduct CreateSignal()
        {
            return new TemperatureSignal(rnd.Next(3), WhereInstalled);
        }
    }

    class MoistureSensor : SensorFactory
    {
        public MoistureSensor(int RoomNumber, Random rand)
        {
            WhereInstalled = (Places)RoomNumber;
            rnd = rand;
        }

        public override AbstractProduct CreateSignal()
        {
            Random rnd = new Random();
            return new MoistureSignal(rnd.Next(3), WhereInstalled);
        }
    }

    class IlluminationSensor : SensorFactory
    {
        public IlluminationSensor(int RoomNumber, Random rand)
        {
            WhereInstalled = (Places)RoomNumber;
            rnd = rand;
        }

        public override AbstractProduct CreateSignal()
        {
            Random rnd = new Random();
            return new IlluminationSignal(rnd.Next(3), WhereInstalled);
        }
    }

    // Конкретные продукты
    abstract class SignalProduct: AbstractProduct
    {
        // Уровень сигнала
        protected SignalValues GetSignal { get; set; }

        // Источник сигнала
        protected Places SignalFrom { get; set; }
    }

    class TemperatureSignal: SignalProduct
    {   
        // Конструктор
        public TemperatureSignal(int SignalCode, Places From)
        {
            GetSignal = (SignalValues)SignalCode;
            SignalFrom = From;
        }

        // Вывод состояния продукта
        public override void ReadValue()
        {
            Console.WriteLine("{0} Temperature at {1}", GetSignal, SignalFrom);
        }
    }

    class MoistureSignal : SignalProduct
    {
        // Конструктор
        public MoistureSignal(int SignalCode, Places From)
        {
            GetSignal = (SignalValues)SignalCode;
            SignalFrom = From;
        }

        // Вывод состояния продукта
        public override void ReadValue()
        {
            Console.WriteLine("{0} Moisture at {1}", GetSignal, SignalFrom);
        }
    }

    class IlluminationSignal : SignalProduct
    {
        // Конструктор
        public IlluminationSignal(int SignalCode, Places From)
        {
            GetSignal = (SignalValues)SignalCode;
            SignalFrom = From;
        }

        // Вывод состояния продукта
        public override void ReadValue()
        {
            Console.WriteLine("{0} Ilumination at {1}", GetSignal, SignalFrom);
        }
    }

    // Клиент считывает данные с датчиков
    class Reader
    {
        // Датчики
        List<SensorFactory> Sensors = new List<SensorFactory>();

        // Конструктор
        public Reader()
        {
            Random rnd = new Random();
            Sensors.Add(new TemperatureSensor(rnd.Next(5), rnd));
            Sensors.Add(new MoistureSensor(rnd.Next(5), rnd));
            Sensors.Add(new IlluminationSensor(rnd.Next(5), rnd));
        }

        // Получение сигналов с датчиков
        public void ReadSignals()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                    Sensors[j].CreateSignal().ReadValue();
                Console.WriteLine();
            }
        }
    }

    // Место, откуда идет сигнал
    enum SensorTypes : byte
    {
        Temperature,
        Moisture,
        Illumination
    }

    // Место, откуда идет сигнал
    enum Places : byte
    {
        Room,
        Kitchen,
        Corridor,
        Garage,
        Outside
    }

    // Значение сигнала
    enum SignalValues : byte
    {
        Low,
        Normal,
        High
    }
}