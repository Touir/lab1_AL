namespace task2
{

    public class Rectangle
    {
        private double sideA;
        private double sideB;

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        
        double AreaCalculator()
        {
            return sideA * sideB;
        }

        double PerimeterCalculator()
        {
            return (sideA + sideB) * 2;
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimetr
        {
            get
            {
                return PerimeterCalculator();
            }
        }
    }

    public class Program
    {
        static void Main()
        {
            double sideA = Convert.ToDouble(Console.ReadLine());
            double sideB = Convert.ToDouble(Console.ReadLine());
            var rec = new Rectangle(sideA, sideB);
            Console.WriteLine("Perimetr of rectangle is {0} \nArea of rectangle is {1}", rec.Perimetr, rec.Area);
        }
    }
}