/*PlayerApp.cs     Author: Doyle
 * Application that instantiates
 * Player class. Creates an array
 * of player objects that can be
 * used to display individual 
 * records or do stats  
 * on the entire team.
 */

using System;
using static System.Console;

namespace PlayerApp
{
    public class PlayerApp
    {
        static void Main( )
        {
            string ln,
                      fn,
                      iden;
            string inValue;

            int playerCnt,
                loopCnt = 0,
                gameCnt;
            int[ ] points = new int[1000];

            Write("How many players? ");
            inValue = ReadLine();
            if (int.TryParse(inValue, out playerCnt) == false)
                WriteLine("Invalid data entered - " +
                                    "0 recorded for number of players."); 
            Player[] teamMember = new Player[playerCnt];
            while (loopCnt < playerCnt)
            {
                GetIdInfo(out ln, out fn, out iden);
                gameCnt = 0;
                points = GetScores(ref gameCnt);
                teamMember[loopCnt] = new Player(ln, fn, iden, points, gameCnt);
                loopCnt++;
            }
            DisplayStats(teamMember);
            ReadKey();
        }

        public static int[ ] GetScores(ref int gameCnt)
        {
            int[ ] points = new int[1000];
            string inValue;

            Write("Game {0}: ((-99 to exit)) ", gameCnt + 1);
            inValue = ReadLine();

            while (inValue != "-99")
            {
                if (int.TryParse(inValue, out points[gameCnt]) == false)
                    WriteLine("Invalid data entered - " +
                                        "0 recorded for points array element");
                ++gameCnt;
                Write("Game {0}: ((-99 to exit)) ", gameCnt + 1);
                inValue = ReadLine();
            }
            return points;
        }

        public static void GetIdInfo(out string ln,
                             out string fn, out string iden)
        {
            WriteLine();
            Write("Player First Name: ");
            fn = ReadLine();
            Write("Player Last Name: ");
            ln = ReadLine();
            Write("Player ID Number: ");
            iden = ReadLine();
        }

        public static void DisplayStats(Player[] teamMember)
        {
            WriteLine();
            WriteLine("{0,12} {1,25}","Player", "Avg Points");
            WriteLine("--------------------------------------");
            foreach (Player pl in teamMember)
            {
                    WriteLine("{0,-25} {1,7}", (pl.FName + " " + pl.LName),
                                      pl.ComputeAverage().ToString("F0"));
            }
        }
    }
}
