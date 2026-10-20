using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    internal class Product
    {
        // Завдання 4
        // Створіть клас Product, який містить інформацію про товар: назву, кількість і ціну.
        // Реалізуйте перевантаження таких операторів:
        // + і - для збільшення або зменшення кількості товару.
        // ==, != для порівняння товарів за ціною.
        // > і < для порівняння товарів за кількістю.
        // Використовуйте властивості для управління кількістю та ціною товару.
        // Додайте перевірку у властивостях, щоб кількість не могла бути від'ємною.
        
        public string ProductName { get; set; }

        private int _ProductCount = 1;
        public int ProductCount
        {
            get;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("ProductCount can't be less than 0");
                }
                else
                {
                    _ProductCount = value;
                }
            }
        }
        public int ProductPrice { get; set; }

        public static int operator +(Product p1, int n)
        {
            return p1.ProductCount + n;
        }
        
        public static int operator -(Product p1, int n)
        {
            return p1.ProductCount - n;
        }

        public static bool operator ==(Product p1, Product p2)
        {
            return p1.ProductPrice == p2.ProductPrice;
        }
        
        public static bool operator !=(Product p1, Product p2)
        {
            return p1.ProductPrice != p2.ProductPrice;
        }

        public static bool operator <(Product p1, Product p2)
        {
            return p1.ProductCount < p2.ProductCount;
        }
        
        public static bool operator >(Product p1, Product p2)
        {
            return p1.ProductCount > p2.ProductCount;
        }
    }
}

