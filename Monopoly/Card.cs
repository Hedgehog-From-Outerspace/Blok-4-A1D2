using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Card
    {
        public int Id { get; set; }
        public string CardText { get; set; }
        public string Effect { get; set; } //Possibly also with inheritence

        public Card(int _Id, string _CardText, string _Effect)
        {
            Id = _Id;
            CardText = _CardText;
            Effect = _Effect;
        }
    }
}
