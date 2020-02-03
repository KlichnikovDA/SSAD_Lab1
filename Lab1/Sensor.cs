using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    // Конкретная фабрика
    class Sensor : AbstractFactory
    {
        // Место расположения датчика
        public Places WhereInstalled { get; private set; }

        // Тип датчика
        public SensorTypes GetSensorType { get; private set; }

        // Конструктор
        public Sensor (int PlaceCode, int TypeCode)
        {
            WhereInstalled = (Places)PlaceCode;
            GetSensorType = (SensorTypes)TypeCode;
        }

        // Создание продукта
        public override AbstractProduct CreateProduct()
        {
            return new Signal(this, new Random().Next(3));
        }
    }

    // Конкретный продукт
    class Signal: AbstractProduct
    {
        // Ссылка на породивший датчик
        private Sensor ParentSensor;
        
        // Уровень сигнала
        public SignalValues GetSignal { get; private set; }
        
        // Конструктор
        public Signal(Sensor Parent, int SignalCode)
        {
            ParentSensor = Parent;
            GetSignal = (SignalValues)SignalCode;
        }

        // Вывод состояния продукта
        public override void ProductAction()
        {
            Console.WriteLine("{0}: {1} {2}", ParentSensor.WhereInstalled, GetSignal, ParentSensor.GetSensorType);
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
