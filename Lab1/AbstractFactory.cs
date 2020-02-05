using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    // Интерфейс абстрактной фабрики
    public abstract class AbstractFactory
    {
        // Создание продукта
        public abstract AbstractProduct CreateSignal();
    }

    // Интерфейс продукта
    public abstract class AbstractProduct
    {
        // Метод продукта
        public abstract void ReadValue();
    }
}
