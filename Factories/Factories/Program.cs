using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories
{
    
    public enum CoordinateSystem
    {
        Cartesian,
        Polar
    }

    public class Point
    {
        /// Factory method
        public static Point NewCartesianPoint(double x , double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double rho , double theta)
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }

        private double x, y;
        /// <summary>
        /// Iniatilez a point from EITHER cartesian or polar
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="system"></param>
        //public Point(double a , double b , CoordinateSystem system = CoordinateSystem.Cartesian)
        //{
        //    this.x = a;
        //    this.y = b;
        //    switch(system)
        //    {
        //        case CoordinateSystem.Cartesian:
        //            x = a;
        //            y = b;
        //            break;
        //        case CoordinateSystem.Polar:
        //            x = a * Math.Cos(a);
        //            y = b * Math.Sin(b);
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException(nameof(system), system, null);
        //    }
        //}

        // ahora lo hacemos privado!
        //public Point (double x , double y)
        private Point (double x , double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var point = Point.NewPolarPoint(1.0, Math.PI / 2);
            Console.WriteLine(point.ToString());
            Console.ReadLine();
        }
    }
}
