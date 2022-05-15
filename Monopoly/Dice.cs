using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Dice
    {
        public int Id { get; set; }
        public Board Board { get; set; }

        public Dice(int _Id)
        {
            Id = _Id;
        }
    }
}
