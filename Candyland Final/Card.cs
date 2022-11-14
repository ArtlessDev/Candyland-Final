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

        public string PickCard(SquareType square)
        {
            Random rnd = new Random();
            int num = rnd.Next(square.ColorTypes.Length);
            string actualSquare = square.ColorTypes[num].ToString();

            return actualSquare;
        }
    }
}
