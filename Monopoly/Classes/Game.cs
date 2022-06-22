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

        public Game(int _Id, string _Name, List<Player> _Players) //List of questions
        {
            Id = _Id;
            Name = _Name;
            Players = _Players;
            CurrentPlayer = GetFirstPlayer();
            Board = new Board(0, this);
            //Board positions needs to be innitialised, all players need to start at start
        }

        public void HandleTurn()
        {
            //Current player rolls the dice 
            int diceRoll = CurrentPlayer.RollDice();
            int index = 0;
            //Determine plot that current player is on
            foreach (Plot plot in Board.Plots)
            {
                if (plot.OccupiedBy.Contains(CurrentPlayer))
                {
                    index = Board.Plots.IndexOf(plot);

                    //Remove current player from prev plot
                    plot.OccupiedBy.Remove(CurrentPlayer);
                }
            }
            //Current player moves to a new plot according to dice rolls
            index += diceRoll;
            Board.Plots[index].OccupiedBy.Add(CurrentPlayer);
            CurrentPlayer.OccupiedPlot = Board.Plots[index];                        //Check of dit een add functie moet zijn

            //Is current plot owned by anyone?
            if (CurrentPlayer.OccupiedPlot.Owner != null)
            {
                //Ask question
                //If answer is incorrect then current player loses money to owner of plot
            }
            else
            {
                //If unowned building plot
                //Option to buy plot
                //If buy plot, player loses money 
            }
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

        public Player DetermineWinner()
        {
            //Player with most money + price owned buildings wins
            return new Player(0, "Winner", "Gold");
        }
    }
}
