using PACMAN.Objects;
using System;
using System.Threading;


namespace TelnetTest
{
    class Program
    {
        static TelnetConnection telnetCon;

        static void Main(string[] args)
        {
            telnetCon = new TelnetConnection(args[0], int.Parse(args[1]));
            telnetCon.Connect();
            Thread.Sleep(2000);
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("*** Attempt number " + i + " ***");
                printTelnetSetReaction(i);
                printTelnetGetReaction(i);
                Console.WriteLine();
            }
            Console.Read();
        }

        private static void printTelnetSetReaction(int num)
        {
            DateTime startTime = DateTime.Now;
           // Console.WriteLine(string.Format("Sending \"B{0}E\" command to telnet.", num));
            telnetCon.WriteLine(string.Format("B{0}E", num));
            string response = telnetCon.Read();
            while (!response.Contains("ACK"))
            {
                response = telnetCon.Read();
            }
            TimeSpan diff = DateTime.Now - startTime;
            Console.WriteLine("Telnet Set responded after:" + diff);
        }

        private static void printTelnetGetReaction(int num)
        {
            DateTime startTime = DateTime.Now;
           // Console.WriteLine("Sending \"A\" command to telnet.");
            telnetCon.WriteLine("A");
            string response = telnetCon.Read();
            while (!response.Contains(num.ToString()))
            {
                response = telnetCon.Read();
            }
            TimeSpan diff = DateTime.Now - startTime;
            Console.WriteLine("Telnet Get responded after:" + diff);
        }

    }
}