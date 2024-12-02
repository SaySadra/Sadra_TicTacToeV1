using System;
using System.Collections;
using System.Collections.Generic;

namespace BLL
{
    public class StructApplication
    {
        public static string[] inputPlayer = new string[] {"1","2","3","4","5","6","7","8","9"};


        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("       |       |       ");
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", inputPlayer[0], inputPlayer[1], inputPlayer[2]);
            Console.WriteLine("       |       |       ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", inputPlayer[3], inputPlayer[4], inputPlayer[5]);
            Console.WriteLine("       |       |       ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", inputPlayer[6], inputPlayer[7], inputPlayer[8]);
            Console.WriteLine("       |       |       ");
            Console.WriteLine("please enter a valid number !");
        }
    }
}
