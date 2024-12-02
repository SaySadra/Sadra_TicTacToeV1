using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserFields
    {
        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("       |       |       ");
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", DataApplication.inputPlayer[0], DataApplication.inputPlayer[1], DataApplication.inputPlayer[2]);
            Console.WriteLine("       |       |       ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", DataApplication.inputPlayer[3], DataApplication.inputPlayer[4], DataApplication.inputPlayer[5]);
            Console.WriteLine("       |       |       ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", DataApplication.inputPlayer[6], DataApplication.inputPlayer[7], DataApplication.inputPlayer[8]);
            Console.WriteLine("       |       |       ");
            Console.WriteLine("please enter a valid number !, for end game please press /, and for restart game please press .");
        }
        public static void ResetGame()
        {
            DataApplication.inputPlayer = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            DataApplication.inputString = "";
            DataApplication.inputNumber = 0;
            DataApplication.counter = 1;
            SetField();
        }
    }
}
