namespace Assignment_5._3._2
{
    internal class Program
    {
        public static Dictionary<int, int> StepsCounted = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            // n= 2, result = 2
            // n = 3, result = 3   111  21 12
            //n = 4, result = 5  , 1111, 211, 121, 112, 22, 
            //n = 5, result = 8  , 11111, 2111, 1211, 1121, 1112, 221, 122, 212
            //n = 6, result = 13  , 111111, 21111, 12111, 11211, 11121, 11112, 2211, 1221, 1122, 222
            //n = 7, result = 21  , 
            
            Console.WriteLine("Enter number of steps: ");
            int.TryParse(Console.ReadLine(), out int steps);
            Console.WriteLine($"Step Possibilities:{CountSteps(steps)}");
            

        }
        static int CountSteps(int n)//11
        {
            
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;

            if (StepsCounted.ContainsKey(n))
            {
                return StepsCounted[n];
            }

            return StepsCounted[n] = CountSteps(n-1) + CountSteps(n-2);

        }
    }

}
