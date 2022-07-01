﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Board
    {
        public int Id { get; set; }
        public List<Card> Deck { get; set; }
        public List<Plot> Plots { get; set; }
        public Game Game { get; set; }

        public Board(int _Id)
        {
            Id = _Id;

            //Read card data from DAL
            Card card = new Card();
            Deck = card.GetStandardList();

            //Read plot data from DAL, hoe het bord eruit ziet.
            Plot plot = new Plot();
            Plots = plot.GetStandardList();
            
            //initialise players at start plot
            foreach (Player player in Game.Players)
            {
                player.OccupiedPlot = Plots[0];
            }
        }

        public Card DrawCard()
        {
            //random card is drawn
            var random = new Random();
            int index = random.Next(Deck.Count);
            Card card = Deck[index];

            //Drawn card is removed from deck
            Deck.Remove(card);
            return card;
        }

        public void BuyPlot()
        {
            //Check if player has enough money
            //detract plot price from player money
            //add player to plot owner
            //add plot to ownedPlots player
        }

        public void AddGame(Game game)
        {
            this.Game = game;
        }

        public void Create()
        {

        }

        public void Read()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
}
