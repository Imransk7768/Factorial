using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorsNumber
{
    public class Factorial
    {
        int factorial;
        public void Fact()
        {
            int Fact = 1;
            Console.WriteLine("Enter The Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                Fact = Fact * i;
            }
            Console.WriteLine("Factorial Number Is: " + Fact);
        }
        public int rFact(int num)
        {
            //
            factorial = rFact(num);
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * rFact(num - 1);
            }
        }
        public static void main()
        {
            Factorial Fac= new Factorial();
            Fac.Fact();
            Console.WriteLine("Enter The Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Fac.rFact(n);
        }

    }

}