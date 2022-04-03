using System;

namespace Task_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] Arr = { 10, 20, 30, 40, 10, 50 };
            Action<double ,double> product = delegate (double x,double y)
              {
                  double result = 0;
                  int i = 0;
                  for (i=0; i < Arr.Length; i++)
                  {
                      result+= Arr[i];
                  }
                  Console.WriteLine($"Pruduct count:{i}");
                  Console.WriteLine($"Prudct TotalPrice:{ result}");
              };
            product(1,1);
        }

    }
}
