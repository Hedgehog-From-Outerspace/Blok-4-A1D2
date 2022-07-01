using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Card
    {
        public int Id { get; set; }
        public string CardText { get; set; }
        public string Effect { get; set; } //Possibly also with inheritence
        private DAL dal;

        public Card(int _Id, string _CardText, string _Effect)
        {
            Id = _Id;
            CardText = _CardText;
            Effect = _Effect;
        }

        public Card()
        {
            dal = new DAL();
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

        public List<Card> GetStandardList()
        {
            return dal.ReadStandardCardList();
        }

        public List<Card> GetList(Board board)
        {
            return dal.ReadCardList(board);
        }
    }
}
