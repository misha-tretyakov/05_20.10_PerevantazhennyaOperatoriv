using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    internal class Journal
    { 
        //     Завдання 1
        // Створіть клас "Журнал". Додайте до вже створеного класу інформацію про кількість співробітників.
        // Виконайте перевантаження
        // + (для збільшення кількості співробітників на зазначену величину),
        // - (для зменшення кількості співробітників на зазначену величину),
        // == (перевірка на рівність кількості співробітників),
        // < і > (перевірка на меншу або більшу кількість співробітників),
        // != і ==. Використовуйте механізм властивостей для полів класу.
        public int WorkersCount { get; set; }

        public static Journal operator +(Journal j, int n)
        {
            return new Journal { WorkersCount = j.WorkersCount + n };
        }

        public static Journal operator -(Journal j, int n)
        {
            return new Journal { WorkersCount = j.WorkersCount - n };
        }

        public static bool operator ==(Journal j1, Journal j2)
        {
            return j1.WorkersCount == j2.WorkersCount;
        }
        
        public static bool operator !=(Journal j1, Journal j2)
        {
            return j1.WorkersCount != j2.WorkersCount;
        }

        public static bool operator >(Journal j1, Journal j2)
        {
            return j1.WorkersCount > j2.WorkersCount;
        }

        public static bool operator <(Journal j1, Journal j2)
        {
            return j1.WorkersCount < j2.WorkersCount;
        }

        override public string ToString()
        {
            return $"Journal WorkersCount = {WorkersCount}";
        }
    }
}