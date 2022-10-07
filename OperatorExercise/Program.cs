namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a/b;
            int remainder = a%b;
            
            if(a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} with a remainder of {remainder}");
               
            }
            Console.WriteLine(AreaOfCircle());
        }
        public static double AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            return Math.PI * radius * radius;
        }
    }
}