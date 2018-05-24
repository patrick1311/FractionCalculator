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
        }

        //overload the + operator
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction sum = new Fraction
            {
                Numerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator,
                Denominator = f1.Denominator * f2.Denominator
            };
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

            return quotient;
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
            //we can do some switch statement to ask user
            //to choose from (+, -, *, /)


            //here is an example for what operator overloading can do
            //u guys feel free to make changes
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(2, 3);
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
