using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyland_Final
{
    class SquareType
    {
        private string[] colorTypes = { 
                                   "doubleBlue", 
                                   "doubleGreen", 
                                   "doubleOrange",
                                   "doublePurple",
                                   "doubleRed",
                                   "doubleYellow",
                                   "singleBlue",
                                   "singleGreen",
                                   "singleOrange",
                                   "singlePurple",
                                   "singleRed",
                                   "singleYellow",
                                   "special"
                                  };
        private string[] specialTypes = {
                                    "specialCandycane",
                                    "specialDonut",
                                    "specialGeneric",
                                    "specialIcecream",
                                    "specialLollipop"
                                    };

        public string[] ColorTypes
        {
            get { return this.colorTypes; }
        }
        public string[] SpecialTypes
        {
            get { return this.specialTypes; }
        }
    }
}
