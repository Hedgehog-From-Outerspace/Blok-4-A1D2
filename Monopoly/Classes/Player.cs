using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Money { get; set; }
        public Plot OccupiedPlot { get; set; }
        private DAL dal;

        public Player(int _Id, string _Name)
        {
            Id = _Id;
            Name = _Name;
            Money = 200;       //According to monopoly rules (Subject to change)
            dal = new DAL();
        }

        public Player()
        {
            dal = new DAL();
        }

        public int RollDice()
        {
            return new Random().Next(1, 6);
        }

        public string BuyPlot(Plot plot)
        {
            string message = "";                        //Do these messages belong here or in the form?
            if (this.Money > plot.Price)
            {
                this.Money -= plot.Price;
                plot.Owner = this;
                message = $"You bought {plot.PlotType}!";
            }
            else
            {
                message = $"You don't have enough money to buy {plot.PlotType}!'";
            }
            return message;
        }

        public void Create()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }

        public List<Player> GetList()
        {
            return new List<Player>();
        }
    }
}
