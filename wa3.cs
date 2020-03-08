using System;
using static System.Console;
using static System.Math;

namespace Bme121
{
    static class Program
    {
        static void Main( )
        {
			
			WriteLine();
			Write("Enter the incident ultrasound frequency (Hertz):");
			double ft = double.Parse(ReadLine());
			WriteLine();
			
			Write("Enter the dopler frequency shift (Hertz):");
			double fd = double.Parse(ReadLine());
			WriteLine();
			
			Write("Enter the dopler angle in (degrees):");
			double a = double.Parse(ReadLine());
			a = (a*3.14)/180;
			WriteLine();
			
			//~ double bv =((fd * c) / ((2*ft)*(Cos(a))));
			
			Write($"The blood velocity is: {equation(ft,fd,a)}  m/s");
			
        }
        static double equation ( double ft , double  fd , double  a)
        {	
			int c = 1540;
			double bv =((fd * c) / (2*ft*Cos(a)));
			return  Round(bv,2);
		}
		
    }
}
