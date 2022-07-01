using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Game
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public List<Player> Players { get; set; }
        public Player CurrentPlayer { get; set; }
        public Board Board { get; set; }
        public List<Question> Questions { get; set; }

        public Game(int _Id, List<Player> _Players, Category _Category) //List of questions
        {
            Id = _Id;
            Players = _Players;
            CurrentPlayer = GetFirstPlayer();
            Board = new Board(0, this);
            Questions = new List<Question>();
            Category = _Category;
        }

        public void HandleTurn()
        {
            MovePlayer();                        
            //CHECK IF EVENT PLOT OR HOUSE PLOT
            if (CurrentPlayer.OccupiedPlot.PlotType == "")
            {

            }
            //Is current plot owned by anyone?
            if (CurrentPlayer.OccupiedPlot.Owner != null)
            {
                Question question = GetQuestion();
                //Show in UI
                //Get Answer
                string answer = "";

                //check answer
                if (!question.CheckAnswer(answer))
                {
                    //Wrong answer, player pays owner
                    CurrentPlayer.Money -= 0;//un geld amount, needs to be a plot attr, or derived gromp 
                    if (CurrentPlayer.Money < 0)
                    {
                        CurrentPlayer.Money = 0;
                    }
                }
            }
            else
            {
                //If unowned building plot
                //Option to buy plot
                //If buy plot, player loses money
                string message = CurrentPlayer.BuyPlot(CurrentPlayer.OccupiedPlot);
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

        public bool CheckIfBankrupt(List<Player> list)
        {
            bool isBankrupt = false;
            foreach (Player player in list)
            {
                if (player.Money <= 0)
                {
                    isBankrupt = true;
                }
            }

            return isBankrupt;
        }

        public void AddCategory(Category category)
        {
            this.Category = category;
        }

        public void MovePlayer()
        {
            //Current player rolls the dice 
            int diceRoll = CurrentPlayer.RollDice();

            //Determine plot that current player is on
            int index = Board.Plots.IndexOf(CurrentPlayer.OccupiedPlot);

            //Current player moves to a new plot according to dice rolls
            index += diceRoll;
            CurrentPlayer.OccupiedPlot = Board.Plots[index];
        }

        public Question GetQuestion()
        {
            Question question = new Question();
            if (Questions.Count > 0)
            {
                var random = new Random();
                int index = random.Next(Questions.Count);
                question = Questions[index];

            }
            else
            {
                Questions.Clear();
                question.GetList(Category);

                var random = new Random();
                int index = random.Next(Questions.Count);
                question = Questions[index];
            }
            return question;
        }
    }
}
