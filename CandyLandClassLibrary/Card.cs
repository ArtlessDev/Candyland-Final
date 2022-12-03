using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyland_Final
{
    public class Card
    {
        string cardImg, cardType;

        public Card()
        {
            cardImg = "picture not set";
            cardType = "type not set";
        }

        public string CardImg
        {
            get
            {
                return cardImg;
            }
            set
            {
                this.cardImg = value;
            }
        }
        public string CardType
        {
            get
            {
                return cardType;
            }
            set
            {
                this.cardType = value;
            }
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
