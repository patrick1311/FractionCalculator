using System;

namespace FractionCalculator 
{
    public class Fraction
    {
        // Class properties include Numerator and Denominator.

        // This demonstrates auto-property initialization
        public int Numerator { get; set; } = 0;

        // This shows that writing a getter and setter is less verbose than
        //writing a getter and setter in Java.
        private int denominator;
        public int Denominator
        {
            get { return denominator; }
            set { denominator = (value != 0) ? value : 1; }
        }
            
        // Constructor with default arguments.
        public Fraction(int num = 0, int den = 1)
        {
            if (den == 0)
            {
                Console.WriteLine("Invalid input! Denominator cannot be 0. Initialize Denominator to 1 by default");
                den = 1;
            }

            Numerator = num;
            Denominator = den;
            simplify();
        }

        //overload the + operator
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction sum = new Fraction
            {
                Numerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator,
                Denominator = f1.Denominator * f2.Denominator
            };
            sum.simplify();
            return sum;
        }

        //overload the - operator
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            Fraction diff = new Fraction
            {
                Numerator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator,
                Denominator = f1.Denominator * f2.Denominator
            };
            diff.simplify();
            return diff;
        }

        //overload the * operator
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction product = new Fraction
            {
                Numerator = f1.Numerator * f2.Numerator,
                Denominator = f1.Denominator * f2.Denominator
            };
            product.simplify();
            return product;
        }

        //overload the / operator
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction quotient = new Fraction
            {
                Numerator = f1.Numerator * f2.Denominator,
                Denominator = f1.Denominator * f2.Numerator
            };
            quotient.simplify();
            return quotient;
        }

        //find the greatest common denominator
        public int GCD(int a, int b)   //gcd for simplification
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }

        //simplify the fraction
        public void simplify()
        {
            int gcd = GCD(Numerator, Denominator);
            Numerator = Numerator / gcd;
            Denominator = Denominator / gcd;
            if (Denominator < 0)
            {
                Denominator = -1 * Denominator;
                Numerator = -1 * Numerator;
            }
        }

        //print object in fraction number format
        public void Print() 
        {
            Console.WriteLine(Numerator + "/" + Denominator);
        }
    }
    
    class MainClass 
    {
        public static void Main(string[] args) 
        {
            Fraction f1 = new Fraction(-1, -2);
            Fraction f2 = new Fraction(1, -2);

            Console.Write("First fraction number = ");
            f1.Print();
            Console.Write("Second fraction number = ");
            f2.Print();

            Fraction sum = f1 + f2;
            Fraction diff = f1 - f2;
            Fraction product = f1 * f2;
            Fraction quotient = f1 / f2;
            Console.Write("sum = ");
            sum.Print();
            Console.Write("diff = ");
            diff.Print();
            Console.Write("product = ");
            product.Print();
            Console.Write("quotient = ");
            quotient.Print();
        }
    }
}
