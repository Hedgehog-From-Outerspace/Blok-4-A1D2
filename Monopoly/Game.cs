using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Game
    {
        public int Id { get; set; }
        public List<Player> Players { get; set; }
        public Player CurrentPlayer { get; set; }
        public Board Board { get; set; }

        public Game(int _Id, List<Player> _Players)
        {
            Id = _Id;
            Players = _Players;
            CurrentPlayer = GetFirstPlayer();
            Board = new Board();
        }

        //Method to randomly determine starting player
        public Player GetFirstPlayer()
        {
            var random = new Random();
            int index = random.Next(Players.Count);
            return Players[index];
        }
    }
}
