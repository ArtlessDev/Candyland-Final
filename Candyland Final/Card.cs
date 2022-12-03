using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyland_Final
{
    class Card
    {
        public string CardImg
        {
            get; set;
        }
        public string CardType
        {
            get; set;
        }

        public string PickCard()
        {
            Random rnd = new Random();
            int num = rnd.Next(SquareType.ColorTypes.Length);
            string actualSquare = SquareType.ColorTypes[num].ToString();
            

            if (actualSquare == "special")
            {
                int newNum = rnd.Next(SquareType.SpecialTypes.Length);
                actualSquare = SquareType.SpecialTypes[newNum].ToString();
                
            }

            return actualSquare;
        }
    }
}
