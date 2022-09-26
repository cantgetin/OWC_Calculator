using System;
using System.Collections.Generic;
using System.Text;

namespace OWC_Calculator
{
    public class Player
    {
        public string Name { get; set; }
        public int NM { get; set; }
        public int HD { get; set; }
        public int HR { get; set; }
        public int DT { get; set; }
        public int FM { get; set; }

        public Player(string name, int nm, int hd, int hr, int dt, int fm)
        {
            Name = name;
            NM = nm;
            HD = hd;
            HR = hr;
            DT = dt;
            FM = fm;
        }
    }
}