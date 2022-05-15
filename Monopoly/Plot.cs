using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Plot
    {
        public int Id { get; set; }
        public string PlotType { get; set; } //Probably better to do through inheritenve
        public Player Owner { get; set; }

        public Plot(int _Id, string _PlotType)
        {
            Id = _Id;
            PlotType = _PlotType;
        }
    }
}
