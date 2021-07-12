using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());

            ushort years = (ushort)(centuries * 100);
            uint days = (uint)Math.Truncate(years * 365.2422);
            long hours = days * 24L;
            ulong minutes = (ulong)hours * 60U;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");



        }
    }
}
