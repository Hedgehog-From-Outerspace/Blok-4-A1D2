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
        public string Color { get; set; }
        public List<Plot> OwnedPlots { get; set; }
        public Plot OccupiedPlot { get; set; }

        public Player(int _Id, string _Name, string _Color)
        {
            Id = _Id;
            Name = _Name;
            Money = 0;       //According to monopoly rules (Subject to change)
            Color = _Color;
            OwnedPlots = new List<Plot>();
        }

        public int RollDice()
        {
            return new Random().Next(1, 6);
        }
    }
}
