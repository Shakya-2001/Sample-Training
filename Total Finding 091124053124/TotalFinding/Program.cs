namespace TotalFinding
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Implement your code here
            int sum = 0;
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine(num2);
            }
            else 
            {
                for (int i = num1; i <= num2; i++) 
                {
                    sum += i;
                    Console.WriteLine(sum);
                }
            }
        }
    }
}