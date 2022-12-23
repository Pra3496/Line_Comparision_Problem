namespace Line_Equation_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcomw! to Line Comparison Pragram");


            Console.WriteLine("Please enter X3 coordinates");
            var X3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter Y3 coordinates");
            var Y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter X4 coordinates");
            var X4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter Y4 coordinates");
            var Y4 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Please enter X5 coordinates");
            var X5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter Y5 coordinates");
            var Y5 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Please enter X6 coordinates");
            var X6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter Y6 coordinates");
            var Y6 = Convert.ToDouble(Console.ReadLine());



            double temp1 = Math.Pow((X4 - X3), 2);
            double temp2 = Math.Pow((Y4 - Y3), 2);
            double Length1 = Math.Sqrt(temp1 + temp2);
            Console.WriteLine("Length of line1: \n" + Length1);

            double temp3 = Math.Pow((X6 - X5), 2);
            double temp4 = Math.Pow((Y6 - Y5), 2);
            double Length2 = Math.Sqrt(temp3 + temp4);
            Console.WriteLine("Length of line2: \n" + Length2);

            if (Length1 == Length2)
            {
                Console.WriteLine("Lenght of two lines are equal\n");
            }
            else
            {
                Console.WriteLine("Lenght of two lines are not equal\n");
            }
        }
    }
}