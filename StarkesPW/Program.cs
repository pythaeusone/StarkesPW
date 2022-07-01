using System;

namespace StarkesPW
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckPw pw = new CheckPw();
            PwGen gen = new PwGen();

            pw.PwChecker("abcdefg");
            pw.PwChecker("abcdefgh");
            pw.PwChecker("abcd1234");
            pw.PwChecker("abcd!!**");
            pw.PwChecker("1234!!**");
            pw.PwChecker("ABCD!!**");
            pw.PwChecker("ABCD1234");
            pw.PwChecker("abcdEFGH");
            pw.PwChecker("abDE1234");
            pw.PwChecker("abDE12!!");
            pw.PwChecker("abDE12**");

            Console.WriteLine("\nDas nennt man ein Passwort: " + gen.GenPW(10));


            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
