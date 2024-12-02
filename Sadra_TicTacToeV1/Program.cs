using System;
using System.Collections;
using System.Collections.Generic;
using BLL;
using DAL;

namespace Sadra_TicTacToeV1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            int inputNumber;
            int counter = 1;
            while (true)
            {
                StructApplication.SetField();
                inputString = Console.ReadLine();
                if (int.TryParse(inputString, out inputNumber) && inputNumber >=1 && inputNumber<=9)
                {
                    if (counter % 2 == 1)
                    {
                        StructApplication.inputPlayer[inputNumber - 1] = "X";
                        counter++;
                    }
                    else if (counter % 2 == 0)
                    {
                        StructApplication.inputPlayer[inputNumber - 1] = "O";
                        counter++;
                    }
                    else if (counter > 9)
                    {
                        Console.WriteLine("your game is draw!");
                        break;
                    }
                }
            }
            
        }
    }
}
