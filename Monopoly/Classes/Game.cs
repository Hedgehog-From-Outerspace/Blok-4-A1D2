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
        public string Name { get; set; }    
        public Category Category { get; set; }
        public string CategoryName { get; set; }
        public List<Player> Players { get; set; }
        public Player CurrentPlayer { get; set; }
        public Board Board { get; set; }
        public List<Question> Questions { get; set; }
        private DAL dal;

        public Game(int _Id, string _Name) //List of questions
        {
            Id = _Id;
            Name = _Name;
            Questions = new List<Question>();
            dal = new DAL();
        }

        public Game()
        {
            dal = new DAL();
        }

        public void HandleTurn()
        {
            MovePlayer();
            //CHECK IF EVENT PLOT OR HOUSE PLOT
            if (CurrentPlayer.OccupiedPlot.PlotType.Contains("House1"))
            {
                EncounterHouse();
            }
            else if (CurrentPlayer.OccupiedPlot.PlotType.Contains("House2"))
            {
                EncounterHouse();
            }
            else if (CurrentPlayer.OccupiedPlot.PlotType.Contains("House3"))
            {
                EncounterHouse();
            }
            else if (CurrentPlayer.OccupiedPlot.PlotType.Contains("Card"))
            {
                EncounterCard();
            }
            else if (CurrentPlayer.OccupiedPlot.PlotType.Contains("Jail"))
            {
                EncounterJail();
            }

            CurrentPlayer = GetNextPlayer();
        }

        //Method to randomly determine starting player
        public Player GetFirstPlayer()
        {
            var random = new Random();
            int index = random.Next(Players.Count);
            return Players[index];
        }

        public Player GetNextPlayer()
        {
            //Current Player is moved to the next in the list
            Players.IndexOf(CurrentPlayer);
            int index = Wrap(Players.IndexOf(CurrentPlayer) + 1, 0, Players.Count());
            return Players[index];
        }

        public Player DetermineWinner()
        {
            //Player with most money + price owned buildings wins
            return new Player(0, "Winner");
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

        public void EncounterCard()
        {

        }

        public void EncounterJail()
        {

        }

        public void EncounterHouse()
        {
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
        }

        public void AddCategory(Category category)
        {
            this.Category = category;
            this.CategoryName = category.Name;
        }

        public void AddPlayers(List<Player> Players)
        {
            this.Players = Players;
        }

        public void AddBoard(Board board)
        {
            this.Board = board;
            board.AddGame(this);
        }

        public void MovePlayer()
        {
            //Current player rolls the dice 
            int diceRoll = CurrentPlayer.RollDice();

            //Determine plot that current player is on
            int index = Board.Plots.IndexOf(CurrentPlayer.OccupiedPlot);

            //Current player moves to a new plot according to dice rolls
            index = Wrap(index + diceRoll, 0, Board.Plots.Count());
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

        private int Wrap (int input, int min, int max)
        {
            //To Wrap around from the end of the list to the start of the list
            //Using modulo makes using input numbers larger than 2 * max possible (or 2*min i guess)
            if (input< min)
            {
                return max-(min-input)%(max-min);
            }
            else
            {
                return min+(input-min)%(max-min);
            }
        }
        
        public List<Game> GetList()
        {
            return dal.ReadGameList();
        }
        
        public void Create(Game game)
        {
            dal.CreateGame(game);
        }

        public void Delete(Game game)
        {
            dal.DeleteGame(game);
        }
    }
}
