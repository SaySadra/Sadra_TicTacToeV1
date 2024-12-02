using BLL;
using DAL;

namespace UI

{
    internal class UI
    {

        static void Main(string[] args)
        {

            while (true)
            {
                SetField();
                DataApplication.inputString = Console.ReadLine();
                if (DataApplication.inputString == "/")
                {
                    break;
                }
                else if (DataApplication.inputString == ".")
                {
                    ResetGame();
                }
                else if (int.TryParse(DataApplication.inputString, out DataApplication.inputNumber) && DataApplication.inputNumber >= 1 && DataApplication.inputNumber <= 9)
                {
                    if (DataApplication.counter % 2 == 1 && DataApplication.counter < 9)
                    {
                        if (DataApplication.inputPlayer[DataApplication.inputNumber - 1] != "X" && DataApplication.inputPlayer[DataApplication.inputNumber - 1] != "O")
                        {
                            DataApplication.inputPlayer[DataApplication.inputNumber - 1] = "X";
                            DataApplication.counter++;
                            if (UserWinRate.Winner("X"))
                            {
                                Console.WriteLine("X WON !!!!!!!!!!!! , press enter to reset game");
                                Console.ReadKey();
                                ResetGame();
                            }
                        }

                    }
                    else if (DataApplication.counter % 2 == 0 && DataApplication.counter < 9)
                    {
                        if (DataApplication.inputPlayer[DataApplication.inputNumber - 1] != "X" && DataApplication.inputPlayer[DataApplication.inputNumber - 1] != "O")
                        {
                            DataApplication.inputPlayer[DataApplication.inputNumber - 1] = "O";
                            DataApplication.counter++;
                            if (UserWinRate.Winner("O"))
                            {
                                Console.WriteLine("O WON !!!!!!!!!!!! , press enter to reset game");
                                Console.ReadKey();
                                ResetGame();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("your game is draw!, press enter to Reset Game");
                        Console.ReadKey();
                        ResetGame();
                    }

                }

                else if (!int.TryParse(DataApplication.inputString, out DataApplication.inputNumber) || DataApplication.inputNumber < 1 || DataApplication.inputNumber > 9)
                {
                    Console.WriteLine("you entered wrong!, press enter to continue");
                    Console.ReadKey();
                    continue;
                }
                
            }
            
            Console.ReadKey();
        }
        
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