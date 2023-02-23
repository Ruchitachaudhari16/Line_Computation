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

            Console.WriteLine("Enter the value of Y2 Coordinate:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of X3 Coordinate:");
            int x3= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of X4 Coordinate:");
            int x4= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of Y3 coordinate:");
            int y3= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of Y4 coordinate: ");
            int y4= Convert.ToInt32(Console.ReadLine());

            double Line1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of Line1 is :" +Line1);

            double Line2=Math.Sqrt(Math.Pow((x4-x3),2)+Math.Pow((y4-y3),2));
            Console.WriteLine("Length of Line2 is:" +Line2);
            double differentiate= Line1.CompareTo(Line2);


            if (differentiate>=0)
            {
                Console.WriteLine("line1 is greater than Line2");
            }
            else
            {
                Console.WriteLine(" Line2 is greater than Line1");
            }
           

            Console.ReadLine();
        }

    }

}  

        
        
        
        
    
