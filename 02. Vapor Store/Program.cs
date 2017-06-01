using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingMoney = double.Parse(Console.ReadLine());
            var money = startingMoney;

            var line = Console.ReadLine();
            while (line != "Game Time")
            {
                double gameprice;
                var gameTitle = string.Empty;

                switch (line)
                {
                    case "OutFall 4":
                        gameprice = 39.99;
                        gameTitle = "OutFall 4";
                        break;
                    case "RoverWatch Origins Edition":
                        gameprice = 39.99;
                        gameTitle = "RoverWatch Origins Edition";
                        break;
                    case "CS: OG":
                        gameprice = 15.99;
                        gameTitle = "CS: OG";
                        break;
                    case "Zplinter Zell":
                        gameprice = 19.99;
                        gameTitle = "Zplinter Zell";
                        break;
                    case "Honored 2":
                        gameprice = 59.99;
                        gameTitle = "Honored 2";
                        break;
                    case "RoverWatch":
                        gameprice = 29.99;
                        gameTitle = "RoverWatch";
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        line = Console.ReadLine();
                        continue;

                }

                if (gameprice > money)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    money -= gameprice;
                    Console.WriteLine($"Bought {gameTitle}");
                }

                if (money == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                line = Console.ReadLine();
            }

            var remainingMoney = startingMoney - money;
            Console.WriteLine($"Total spent: ${remainingMoney:F2}. Remaining: ${money:F2}");


        }
    }
}