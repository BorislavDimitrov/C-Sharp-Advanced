using System;

namespace Date
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateModifier modifier = new DateModifier();
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            modifier.DaysDiff = DateModifier.CalculateDaysDiff(firstDate , secondDate);
            Console.WriteLine(Math.Abs(modifier.DaysDiff));
        }
    }
}
