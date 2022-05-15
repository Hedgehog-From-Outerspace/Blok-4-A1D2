using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Board
    {
        public int Id { get; set; }
        public Game Game { get; set; }
        public List<Card> Cards { get; set; }
        public List<Plot> Plots { get; set; }
        public Dice Dice { get; set; }

        public Board(int _Id, Game _Game)
        {
            Id = _Id;
            Game = _Game;
            Cards = new List<Card>();   //This is data that never changes, need a cardInfo class? Enum?
            Plots = new List<Plot>();
            Dice = new Dice();
        }
    }
}
