using System;

namespace StarkesPW
{
    class CheckPw
    {
        public void PwChecker(string pw)
        {
            SplitPW spw = new SplitPW();
            CheckStrongPw cspw = new CheckStrongPw();
            spw.PwSplit(pw);
            cspw.StrongPw();

            if (pw.Length >= 8)
            { 
                switch (cspw.countStrong)
                {
                    case 1:
                        Console.Write(pw + " ist ein ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("sehr schwaches Passwort !\n");
                        Console.ResetColor();
                        break;
                    case 2:
                        Console.Write(pw + " ist ein ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("schwaches Passwort!\n");
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.Write(pw + " ist ein ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("mittel starkes Passwort!\n");
                        Console.ResetColor();
                        break;
                    case 4:
                        Console.Write(pw + " ist ein ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Starkes Passwort!\n");
                        Console.ResetColor();
                        break;
                }
                PwConditions.uppCase = false;
                PwConditions.lowCase = false;
                PwConditions.hasNum = false;
                PwConditions.specChars = false;
            }
            else
            {
                Console.WriteLine("Passwort muss min 8 Zeichen haben!\n");
            }
        }
    }
}
