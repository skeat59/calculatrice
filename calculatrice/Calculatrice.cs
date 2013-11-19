using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;

namespace calculatrice
{
    class Calculatrice
    {
        public static long Simple_operation(long operand1, char operation, long operand2)
        {
            long result;
            switch (operation )
            {
                case '+' :
                    result = operand1 + operand2;
                    break;
                case '-':
                    result = operand1 - operand2;
                    break;  
                case '*':
                    result = operand1 * operand2;
                    break;
                case '/':
                    result = operand1/operand2;
                    break;
                case '%':
                    result = operand1%operand2;
                    break;
                default :
                    result = 42;
                    break;

            }
            return result;

        }

        public static long Pow(int x, int n)
        {
            long result = 1;
            for (int i = 0; i < n; i++)
            {
                result = result*x;
            }
            return result;
        }

        public static double Fibo(uint n)
        {
            double result;
            if (n == 0)
            {
                result = 0;
            }
            else
            {
                if (n == 1)
                {
                    result = 1;
                }
                else
                {
                    result = Fibo(n - 2) + Fibo(n - 1);
                }
            }
            return result;
        }

        public static double Factorial(uint n)
        {
            double result = 1;
            for (int i = 0; i < n; i++)
            {
                result = result*n;
                n = n - 1;
            }
            return result;
        }

        public static double abs(double x)
        {
            if (x < 0)
            {
                return (- x);
            }
            else
            {
                return x;
            }
        }
        
       /* public static double Sqrt(double n, double x)
        {
            float precision = 0.00001f;
            int xi = Convert.ToInt32(x);
            long xca = Pow(xi, 2);
            double res = 0;
            if ((n- xca) >= precision  )
            {
                Sqrt(n,((n - x)/x)/2);
            }
            
                return x; 
            
           
        }*/
    }
}
