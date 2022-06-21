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
        public string Name { get; set; }    
        public List<Player> Players { get; set; }
        public Player CurrentPlayer { get; set; }
        public Board Board { get; set; }
        public List<Question> Questions { get; set; }

        public Game(int _Id, string _Name, List<Player> _Players)
        {
            Id = _Id;
            Name = _Name;
            Players = _Players;
            CurrentPlayer = GetFirstPlayer();
            Board = new Board(0);
        }

        public void HandleTurn()
        {

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
