using System;

namespace FractionCalculator {
    public class Fraction {
        private int numerator;
        private int denominator;

        //default constructor
        public Fraction() {

        }

        //constructor
        public Fraction(int num, int den) {
            if (den == 0) {
                Console.WriteLine("Invalid input! Denominator cannot be 0. Initialize denominator to 1 by default");
                den = 1;
            }

            numerator = num;
            denominator = den;
        }

        //overload the + operator
        public static Fraction operator +(Fraction f1, Fraction f2) {
            Fraction sum = new Fraction();
            sum.numerator = f1.numerator * f2.denominator + f2.numerator * f1.denominator;
            sum.denominator = f1.denominator * f2.denominator;

            return sum;
        }

        //overload the - operator
        public static Fraction operator -(Fraction f1, Fraction f2) {
            Fraction diff = new Fraction();
            diff.numerator = f1.numerator * f2.denominator - f2.numerator * f1.denominator;
            diff.denominator = f1.denominator * f2.denominator;

            return diff;
        }

        //overload the * operator
        public static Fraction operator *(Fraction f1, Fraction f2) {
            Fraction product = new Fraction();
            product.numerator = f1.numerator * f2.numerator;
            product.denominator = f1.denominator * f2.denominator;

            return product;
        }

        //overload the / operator
        public static Fraction operator /(Fraction f1, Fraction f2) {
            Fraction quotient = new Fraction();
            quotient.numerator = f1.numerator * f2.denominator;
            quotient.denominator = f1.denominator * f2.numerator;

            return quotient;
        }

        //print object in fraction number format
        public void print() {
            Console.WriteLine(numerator + "/" + denominator);
        }

    }


    class MainClass {
        public static void Main(string[] args) {
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
            sum.print();
            Console.Write("diff = ");
            diff.print();
            Console.Write("product = ");
            product.print();
            Console.Write("quotient = ");
            quotient.print();
        }
    }
}