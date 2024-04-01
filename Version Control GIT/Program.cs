using System.Transactions;

namespace Version_Control_GIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter floor width");
            int InchWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter floor lenght");
            int InchLenght = Convert.ToInt32(Console.ReadLine());

            decimal totalWightInFeet = (InchWidth / 12);
            decimal totalLanghtInFeet = InchLenght / 12;    
            var totalArea = totalLanghtInFeet * totalWightInFeet;
            Console.WriteLine(totalArea);

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
