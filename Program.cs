using System;
using LiteDB;

namespace darkroom
{
    class Program
    {
        static void Main(string[] args)
        {
            DB db = new DB();
            db.setup();
            Game game = new Game();

            Console.WriteLine("Welcome, " + game.getPlayer().getName());
            
            Choice choice = new Choice("a", "b", "c", "d");
            choice.getOptions();
            String playersChoice = game.createChoice("Where would you like to go?");

            if(game.getDeadPath().Contains(playersChoice)) {
                game.end();
            }

            if(playersChoice == "a") {
                Console.WriteLine("Ooh, you caress the wall. Now the others are jealous:");
                Choice secondChoice = new Choice("e", "f", "g", "h");

                secondChoice.getOptions();
                String playerSecondChoice = game.createChoice("What will you do?");
                
                if(game.getDeadPath().Contains(playerSecondChoice)) {
                    game.end();
                }
            }
        }
    }
}
