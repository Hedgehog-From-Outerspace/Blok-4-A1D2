﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Plot
    {
        public int Id { get; set; }
        public string PlotType { get; set; } //Probably better to do through inheritence
        public int Price { get; set; }
        public Player Owner { get; set; }
        public List<Player> OccupiedBy { get; set; }

        public Plot(int _Id, string _PlotType)
        {
            Id = _Id;
            PlotType = _PlotType;
            OccupiedBy = new List<Player>();
        }
    }
}
