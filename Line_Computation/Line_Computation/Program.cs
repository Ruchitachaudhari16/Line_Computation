using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Line_Computation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Calculate the Length of Line having Coordinate X1,Y1,X2,Y2;
            Console.WriteLine("Enter the value of X1 Coordinate:");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of X2 Coordinate:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of Y1 Coordinate:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of Y2 Coordinate");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double LengthOfLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of Line is :" + LengthOfLine);
            Console.ReadLine();
        }

    }

}  

        
        
        
        
    
