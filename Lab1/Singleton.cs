using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Singleton
    {
        // Экземпляр класса
        private static Singleton Instance;

        // Конструктор
        private Singleton()
        { }

        // Создание экзмепляра класса
        public static Singleton getInstance()
        {
            if (Instance == null)
                Instance = new Singleton();
            return Instance;
        }
    }

    class House
    {
        // Экземпляр класса
        private static House Instance;

        // Адрес
        public static string GetAddress { get; private set; }

        // Количество комнат
        public static int GetRooms { get; private set; }
        
        // Конструктор
        private House(string Address, int RoomNumber)
        {
            GetAddress = Address;
            GetRooms = RoomNumber;
        }

        // Создание экзмепляра класса
        public static House getInstance()
        {
            if (Instance == null)
                Instance = CreateInstance();
            return Instance;
        }

        // Ввод параметров для создания экземпляра класса
        private static House CreateInstance()
        {
            Console.Write("Введите адрес: ");
            string NewAddress = Console.ReadLine();
            Console.Write("Введите количество комнат: ");
            int NewRooms = Int32.Parse(Console.ReadLine());
            return new House(NewAddress, NewRooms);
        }
    }

}