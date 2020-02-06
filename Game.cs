using System.Collections.Generic;
using System;
namespace darkroom
{
    class Game
    {
        private Player player;

        public Game()
        {
            Console.WriteLine("Enter the name for your player: ");
            String playerName = Console.ReadLine();
            this.setCurrentPlayer(playerName);
        }

        public void setCurrentPlayer(String playerName)
        {
            this.player = new Player(playerName);
        }

        public Player getPlayer()
        {
            return this.player;
        }

        public String createChoice(String question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public List<string> getDeadPath()
        {
            List<string> path = new List<string>();
            path.Add("b");
            path.Add("f");
            path.Add("j");

            return path;
        }

        public void end()
        {
            Console.WriteLine("Youre dead");
        }
    }
}