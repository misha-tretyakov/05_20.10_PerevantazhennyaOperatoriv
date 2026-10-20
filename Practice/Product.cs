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
        public int ProductCount { get; set; }
        public int ProductPrice { get; set; }
        
        
    }
}

