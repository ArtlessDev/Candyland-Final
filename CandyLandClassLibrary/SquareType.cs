using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyland_Final
{
    public class SquareType
    {
        private static string[] colorTypes = { 
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
        private static string[] specialTypes = {
                                    "specialCandycane",
                                    "specialDonut",
                                    "specialGeneric",
                                    "specialIcecream",
                                    "specialLollipop"
                                    };

        public static string[] ColorTypes
        {
            get { return colorTypes; }
        }
        public static string[] SpecialTypes
        {
            get { return specialTypes; }
        }
    }
}
