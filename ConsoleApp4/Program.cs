namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ConsoleApp4!");
            Console.WriteLine("Hello, World!");
            
            // Display greeting with local time
            var currentTime = DateTime.Now.ToString("h:mmt").ToLower();
            Console.WriteLine($"Greetings... It is now {currentTime}");
        }
    }
}
