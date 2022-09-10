using Microsoft.Diagnostics.Tracing.Parsers.Clr;

namespace task3 {
    public class Point { 
        private double _x;
        private double _y;

        public Point(double x, double y)
        {
            this._x = x; this._y = y;
        }

        public double x
        {
            get {
                return _x;
            }
        }
        public double y 
        {
            get {
                return _y;
            }
        }
    }

    public class Figure
    {
        private Point[] points;
        public string? name { get; set; }

        public Figure(int n, string name)
        {
            this.name = name;   
            points = new Point[n];
            if (n >= 3 || n <=5)
            {
                for (int i = 0; i < n; ++i)
                {
                    Console.WriteLine("Point {0}:", i+1);
                    double x = Convert.ToDouble(Console.ReadLine());
                    double y = Convert.ToDouble(Console.ReadLine());
                    points[i] = new Point(x, y);
                }
            }
            else
            {
                Console.WriteLine("Invalid number of points!!! \n");
            }
        }

        double LengthSide(Point A, Point B) 
        {
            double length = Math.Sqrt((B.x - A.x)*(B.x - A.x) + (B.y - A.y)*(B.y - A.y));
            return length;
        }

        double PerimeterCalculator() 
        {
            double perimetr = 0;
            for (int i = 0; i < points.Length - 1; ++i) 
            {
                perimetr += LengthSide(points[i], points[i + 1]);
            }
            perimetr += LengthSide(points[points.Length - 1], points[0]);
            return perimetr;
        }

        public double Perimetr
        {
            get 
            { 
                return PerimeterCalculator();
            }
        }
    }

    public class Program {
        static void Main() {
            Console.WriteLine("Quantity of points in figure :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name of figure:");
            string? name = Console.ReadLine();
            var fig = new Figure(n, name);
            Console.WriteLine("Perimetr of figure {0} is {1}",fig.name, fig.Perimetr);
        }
    }

}