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
        public List<Card> Deck { get; set; }
        public List<Plot> Plots { get; set; }

        public Board(int _Id)
        {
            Id = _Id;
            Deck = new List<Card>();   //This is data that never changes, need a cardInfo class? Enum?
            Plots = new List<Plot>();
        }

        public int RollDice()
        {
            return new Random().Next(1,6);
        }

        public Card GetCard()
        {
            return new Card(0, "Hahahah board is gone", "Destroy everything");
        }

        public void BuyPlot()
        {

        }
    }
}
