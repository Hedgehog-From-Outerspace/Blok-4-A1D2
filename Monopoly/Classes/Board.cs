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
            Deck = new List<Card>();
            //Read card data from DAL

            Plots = new List<Plot>();
            //Read plot data from DAL, hoe het bord eruit ziet.

            //initialise players at start plot
            //(Board heeft geen relatie met player, moet board dit dan doen? Moeten de relaties veranderen?)
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
