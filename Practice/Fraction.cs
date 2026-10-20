using System;
using System.Collections.Generic;
using System.Text;

namespace Practice;

public class Fraction
{
        // Завдання 3
        // Створіть клас Fraction, який представляє дріб із чисельником і знаменником. Реалізуйте перевантаження операторів:
        // +, -, *, / для арифметичних операцій між дробами.
        // == і != для порівняння дробів на рівність.
        // Використовуйте властивості для керування чисельником і знаменником дробу,
        // перевіряючи, що знаменник не дорівнює нулю. Додайте метод для приведення дробу до скороченого вигляду.
        public int numerator { get; set; }
        private int _denominator = 1;

        public int denominator
        {
                get;
                set
                { 
                        if (value == 0)
                        {
                                Console.WriteLine("ZeroDivisionError");
                        }
                        else
                        {
                                _denominator = value;
                        }
                }
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
                return new Fraction
                {
                        numerator = a.numerator*b.numerator, 
                        denominator = a.denominator*b.denominator
                };
        }
        
        public static Fraction operator +(Fraction a, Fraction b)
        {
                return new Fraction
                {
                        numerator = a.numerator * b.denominator + b.numerator * a.denominator,
                        denominator = a.denominator * b.denominator
                };
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
                return new Fraction
                {
                        numerator = a.numerator * b.denominator - b.numerator * a.denominator,
                        denominator = a.denominator * b.denominator
                };
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
                return new Fraction
                {
                        numerator = a.numerator * b.denominator,
                        denominator = a.denominator * b.numerator
                };
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
                return a.numerator == b.numerator && a.denominator == b.denominator;
        }
        
        public static bool operator !=(Fraction a, Fraction b)
        {
                return a.numerator != b.numerator && a.denominator != b.denominator;
        }
        
        public void Simplify()
        {
                int a = numerator;
                int b = denominator;

                if (a < 0)
                {
                        a = -a;
                }

                if (b < 0)
                {
                        b = -b;
                }

                while (b != 0)
                {
                        int remainder = a % b;
                        a = b;
                        b = remainder;
                }

                numerator /= a;
                denominator /= a;
        }

        override public string ToString()
        {
                return $"{numerator}/{denominator}";
        }
}