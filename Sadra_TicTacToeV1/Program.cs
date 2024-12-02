using BLL;

namespace Sadra_TicTacToeV1

{
    internal class Program
    {
        public static string inputString = "";
        public static int inputNumber = 0;
        public static int counter = 1;
        public static string[] inputPlayer = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static void Main(string[] args)
        {

            while (inputString != "/")
            {
                SetField();
                inputString = Console.ReadLine();
                if (int.TryParse(inputString, out inputNumber) && inputNumber >= 1 && inputNumber <= 9)
                {
                    if (counter % 2 == 1)
                    {
                        if (inputPlayer[inputNumber - 1] != "X" && inputPlayer[inputNumber - 1] != "O")
                        {
                            inputPlayer[inputNumber - 1] = "X";
                            counter++;
                        }

                    }
                    else if (counter % 2 == 0)
                    {
                        if (inputPlayer[inputNumber - 1] != "X" && inputPlayer[inputNumber - 1] != "O")
                        {
                            inputPlayer[inputNumber - 1] = "O";
                            counter++;
                        }
                    }
                    if (counter > 9)
                    {
                        Console.WriteLine("your game is draw!, press enter to Reset Game");
                        Console.ReadKey();
                        ResetGame();
                    }
                    if (inputString == "/")
                    {
                        break;
                    }
                }
                Console.Clear();
            }
            
            Console.ReadKey();
        }
        
        public static void SetField()
        {
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
        public static void ResetGame()
        {
            inputPlayer = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            inputString = "";
            inputNumber = 0;
            counter = 1;
            SetField();
        }
    }
}