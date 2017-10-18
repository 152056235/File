using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace github1
{  public   class Calculator{
    public void math(int a, int b)
    {
        Console.WriteLine("请选择运算符$$$$$$$$$$   1.+，   2.-，   3.*，  4.÷   #######}：");
        int c = Convert.ToInt32(Console.ReadLine());
       
        switch (c)
        {


            case 1:
                Console.WriteLine(a + b);
                break;
            case 2:
                Console.WriteLine(a - b);
                break;
            case 3:
                Console.WriteLine(a * b);
                break;
            case 4:
                try
                {
                    int s = a / b;
                    Console.WriteLine(s);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The denominator cannot be 0");
                    //throw ex;
                };
                break;
        }

    }
    public void math(string w, string d)
    {
        Console.WriteLine("请选择运算符{1.+，2.-}：");
        int i = Convert.ToInt32(Console.ReadLine());
        switch (i)
        {
            case 1: Console.WriteLine(w + d); break;
            case 2:
                {
                    if (w.Contains(d))
                    { Console.WriteLine(w.Replace(d, "")); }
                } break;
        }
}
         

