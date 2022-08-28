using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App20
{
    class Program
    {
        //delegate double MyDelegate(double a, double b);
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            //MyDelegate myDelegate = PowerAB;
            //int r = myDelegate(2, 10);
            //Console.WriteLine(r);

            //myDelegate = PowerBA;
            //r = myDelegate(2, 10);
            //Console.WriteLine(r);
            MyDelegate myDelegate = PowerAB;
            myDelegate += PowerBA;
            myDelegate += PowerBAS;
            myDelegate(1);
            //Console.WriteLine(r);
            Console.ReadKey();
        }

        static double PowerAB(double r)
        {
            double D = 2*Math.PI*r;
            Console.WriteLine(D);
            return D;
        }
        static double PowerBA(double r)
        {
            double S = Math.PI*r*r;
            Console.WriteLine(S);
            return S;
        } static double PowerBAS(double r)
        {
            double V = 4.0*Math.PI*r*r*r/3;
            Console.WriteLine(V);
            return V;
        }

        //static int PowerAB(int a, int b) => (int)Math.Pow(a, b);
        //static int PowerBA(int a, int b) => (int)Math.Pow(b, a);
        //{
        //int p= 1;
        //for (int i = 0; i < b; i++)
        //{
        //    p*= a;
        //}
        //return p;
        //return (int)Math.Round(Math.Pow(a, b));
        //}
    }
}
