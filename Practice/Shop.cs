using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    internal class Shop
    {
        // Завдання 2
        // Створіть клас "Магазин". Додайте інформацію про площу магазину.
        // Виконайте перевантаження
        // + (для збільшення площі магазину на зазначену величину),
        // - (для зменшення площі магазину на зазначену величину),
        // == (перевірка на рівність площ магазинів),
        // < і > (перевірка на меншу або більшу за площу магазину),
        // != і ==. Використовуйте механізм властивостей для полів класу.
        public int Area { get; set; }

        public static Shop operator +(Shop shop1, int n)
        {
            return new Shop { Area = shop1.Area + n };
        }
        
        public static Shop operator -(Shop j, int n)
        {
            return new Shop { Area = j.Area - n };
        }

        public static bool operator ==(Shop j1, Shop j2)
        {
            return j1.Area == j2.Area;
        }
        
        public static bool operator !=(Shop j1, Shop j2)
        {
            return j1.Area != j2.Area;
        }

        public static bool operator >(Shop j1, Shop j2)
        {
            return j1.Area > j2.Area;
        }

        public static bool operator <(Shop j1, Shop j2)
        {
            return j1.Area < j2.Area;
        }

        override public string ToString()
        {
            return $"Shop's Area = {Area}";
        }
    }
}