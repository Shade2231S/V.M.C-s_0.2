using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V.M.C_s_0._2
{
    internal class Program
    {
        static float score = 0;
        static float currentScore;
        static float currentMult = 1;
        static ConsoleColor OriginalColor;
        static ConsoleColor TextColor = ConsoleColor.DarkMagenta;
        static ConsoleColor HUDColor = ConsoleColor.DarkGreen;
        static ConsoleColor ScoreColor = ConsoleColor.DarkBlue;
        static ConsoleColor MultColor = ConsoleColor.DarkRed;
        static void Main(string[] args)
        {
            Console.ForegroundColor = TextColor;
            score = currentScore;           
            ShowHUD();
            Console.ReadKey(true);
            Console.Clear();
            AddScore(10);
            Console.ReadKey(true);
            Console.Clear();
            ShowHUD();
            Console.ReadKey(true);
            Console.Clear();
            ScoreMultipliyer(1);
            Console.ReadKey(true);
            Console.Clear();
            AddScore(10);
            Console.ReadKey(true);
            Console.Clear();
            ShowHUD();
            Console.ReadKey(true);
            Console.Clear();
            ScoreMultipliyer(3);
            Console.ReadKey(true);
            Console.Clear();
            AddScore(10);
            Console.ReadKey(true);
            Console.Clear();
            ShowHUD();
            Console.ReadKey(true);
            Console.Clear();
            Console.ForegroundColor = OriginalColor;
        }
        static void AddScore(float scoreEarned)
        {
            Console.ForegroundColor = ScoreColor;
            if (currentMult > 0)
            {
                scoreEarned *= currentMult;
            }
            currentScore += scoreEarned;
            Console.WriteLine("===================");
            Console.WriteLine("Score Was Earned! - " + scoreEarned);
            Console.WriteLine("===================");
            Console.ForegroundColor = TextColor;
        }
        static void ScoreMultipliyer(float scoreMult)
        {
            Console.ForegroundColor = MultColor;
            currentMult += scoreMult;
            Console.WriteLine("++++++++++++++++++");
            Console.WriteLine("Score Multipiler Went Up! - " + scoreMult);
            Console.WriteLine("++++++++++++++++++");
            Console.ForegroundColor = TextColor;
        }
        static void ScoreDeMultipliyer(float scoreMult)
        {
            Console.ForegroundColor = MultColor;
            currentMult -= scoreMult;
            Console.WriteLine("-----------------");
            Console.WriteLine("Score Multiplier Went Down! - " + scoreMult);
            Console.WriteLine("-----------------");
            Console.ForegroundColor = TextColor;
        }
        static void ShowHUD()
        {
            Console.ForegroundColor = HUDColor;
            Console.WriteLine("===================");
            Console.WriteLine("Score - " + currentScore);
            Console.WriteLine("Score Multiplier - " + currentMult);
            Console.WriteLine("===================");
            Console.ForegroundColor = TextColor;
        }
    }
}
