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
            //Board positions needs to be innitialised, all players need to start at start
        }

        public void HandleTurn()
        {
            //In a turn multiple things need to happen

            //Current player rolls the dice 
            int DiceRoll = CurrentPlayer.RollDice();

            //Current player moves to a new plot according to dice rolls

            //Foreach plot in board.plots
            //if plot == CurrentPlayer.OccupiedPlot
            //int plotnr == index nr plots
            //int newPlotNr = plotnr + DiceRoll
            //CurrentPlayer.OccupiedPlot = Board.Plots[newPlotNr]

            //Is current plot owned by anyone?
            //If so
            //Ask question
            //If answer is incorrect then current player loses money to owner of plot

            //If unowned building plot
            //Option to buy plot
            //If buy plot, player loses money 

            //If event plot
            //Player is affected by effect

            //Current Player is moved to the next in the list
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
