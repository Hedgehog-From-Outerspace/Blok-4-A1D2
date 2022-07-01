using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Plot
    {
        //Start
        //House1
        //House2
        //House3
        //Card
        //Free Parking
        //Jail
        //End

        public int Id { get; set; }
        public string PlotType { get; set; } //Probably better to do through inheritence
        public int Price { get; set; }
        public Player Owner { get; set; }
        private DAL dal;

        public Plot(int _Id, string _PlotType)
        {
            Id = _Id;
            PlotType = _PlotType;
        }

        public Plot()
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

        public List<Plot> GetList(Board board)
        {
            return dal.ReadPlotList(board);
        }

        public List<Plot> GetStandardList()
        {
            return dal.ReadStandardPlotList();
        }
    }
}
