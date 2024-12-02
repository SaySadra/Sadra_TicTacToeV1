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
                UserFields.SetField();
                DataApplication.inputString = Console.ReadLine();
                if (DataApplication.inputString == "/")
                {
                    break;
                }
                else if (DataApplication.inputString == ".")
                {
                    UserFields.ResetGame();
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
                                UserFields.ResetGame();
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
                                UserFields.ResetGame();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("your game is draw!, press enter to Reset Game");
                        Console.ReadKey();
                        UserFields.ResetGame();
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
        


    }
}