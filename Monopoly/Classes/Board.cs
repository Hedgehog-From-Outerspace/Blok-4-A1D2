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
        public Game Game { get; set; }

        public Board(int _Id, Game _Game)
        {
            Id = _Id;
            Game = _Game;

            //Read card data from DAL
            Deck = new List<Card>();
            for (int i = 0; i < 15; i++)
            {
                Card card = new Card(0, "Cardtext: " + i.ToString(), "Effect: " + i.ToString());
                Deck.Add(card);
            }

            //Read plot data from DAL, hoe het bord eruit ziet.
            Plots = new List<Plot>();
            for (int i = 0; i < 30; i++)
            {
                Plot plot = new Plot(0, "huis");
                Plots.Add(plot);
            }
            //initialise players at start plot
            foreach (Player player in Game.Players)
            {
                Plots[0].OccupiedBy.Add(player);
                player.OccupiedPlot = Plots[0]; //CHECK MET MIEL OF DIT NIET EEN ADD FUNCTIE MOET ZIJN
            }
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
