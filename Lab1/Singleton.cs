using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class SingletonSensor
    {
        // Экземпляр класса
        private static SingletonSensor Instance;

        // Адрес
        public SensorTypes GetSensorType { get; private set; }

        // Количество комнат
        public Places GetRoom { get; private set; }
        
        // Конструктор
        private SingletonSensor(int TypeNumber, int RoomNumber)
        {
            GetSensorType = (SensorTypes)TypeNumber;
            GetRoom = (Places)RoomNumber;
        }

        // Создание экзмепляра класса
        public static SingletonSensor GetInstance(int TypeNumber, int RoomNumber)
        {
            if (Instance == null)
                Instance = new SingletonSensor(TypeNumber, RoomNumber);
            return Instance;
        }
    }
}