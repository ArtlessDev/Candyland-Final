using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyland_Final
{
    class Board
    {
        Space[] spaces = new Space[67];
        public Board()
        {
            //Space[] spaces = new Space[67];
            

            spaces[0] = new Space("red", 165, 100);
            spaces[1] = new Space("orange", 195, 100);
            spaces[2] = new Space("yellow", 225, 100);
            spaces[3] = new Space("green", 255, 100);
            spaces[4] = new Space("blue", 285, 100);
            spaces[5] = new Space("purple", 315, 100);
            spaces[6] = new Space("red", 345, 100);
            spaces[7] = new Space("orange", 375, 100);
            spaces[8] = new Space("yellow", 405, 100);
            spaces[9] = new Space("green", 435, 100);

            spaces[10] = new Space("specialLollipop", 435, 130);

            spaces[11] = new Space("purple", 435, 160);
            spaces[12] = new Space("red", 405, 160);
            spaces[13] = new Space("orange", 375, 160);
            spaces[14] = new Space("yellow", 345, 160);
            spaces[15] = new Space("green", 315, 160);
            spaces[16] = new Space("blue", 285, 160);
            spaces[17] = new Space("purple", 255, 160);
            spaces[18] = new Space("red", 225, 160);
            spaces[19] = new Space("specialIcecream", 195, 160);
            spaces[20] = new Space("yellow", 165, 160);
            spaces[21] = new Space("green", 135, 160);
            spaces[22] = new Space("blue", 105, 160);
            spaces[23] = new Space("purple", 75, 160);
            spaces[24] = new Space("red", 45, 160);

            spaces[25] = new Space("specialCandycane", 45, 190);

            spaces[26] = new Space("yellow", 45, 220);
            spaces[27] = new Space("green", 75, 220);
            spaces[28] = new Space("blue", 105, 220);
            spaces[29] = new Space("purple", 135, 220);
            spaces[30] = new Space("red", 165, 220);
            spaces[31] = new Space("orange", 195, 220);
            spaces[32] = new Space("yellow", 225, 220);
            spaces[33] = new Space("green", 255, 220);
            spaces[34] = new Space("blue", 285, 220);
            spaces[35] = new Space("specialGeneric", 315, 220);
            spaces[36] = new Space("red", 345, 220);
            spaces[37] = new Space("orange", 375, 220);
            spaces[38] = new Space("yellow", 405, 220);
            spaces[39] = new Space("green", 435, 220);

            spaces[40] = new Space("blue", 435, 250);

            spaces[41] = new Space("purple", 435, 280);
            spaces[42] = new Space("red", 405, 280);
            spaces[43] = new Space("orange", 375, 280);
            spaces[44] = new Space("yellow", 345, 280);
            spaces[45] = new Space("green", 315, 280);
            spaces[46] = new Space("blue", 285, 280);
            spaces[47] = new Space("purple", 255, 280);
            spaces[48] = new Space("specialDonut", 225, 280);
            spaces[49] = new Space("orange", 195, 280);
            spaces[50] = new Space("yellow", 165, 280);
            spaces[51] = new Space("green", 135, 280);
            spaces[52] = new Space("blue", 105, 280);
            spaces[53] = new Space("purple", 75, 280);
            spaces[54] = new Space("red", 45, 280);

            spaces[55] = new Space("orange", 45, 310);

            spaces[56] = new Space("yellow", 45, 340);
            spaces[57] = new Space("green", 75, 340);
            spaces[58] = new Space("blue", 105, 340);
            spaces[59] = new Space("purple", 135, 340);
            spaces[60] = new Space("red", 165, 340);
            spaces[61] = new Space("orange", 195, 340);
            spaces[62] = new Space("yellow", 225, 340);
            spaces[63] = new Space("green", 255, 340);
            spaces[64] = new Space("blue", 285, 340);
            spaces[65] = new Space("purple", 315, 340);

            spaces[66] = new Space("finish", 375, 340);
        }

        public int GetLeft(Player player)
        {
            Console.WriteLine("x: " + spaces[player.Position].XValue);
            int x = spaces[player.Position].XValue;

            return x;
        }
        public int GetTop(Player player)
        {
            Console.WriteLine("y: " + spaces[player.Position].YValue);
            int y = spaces[player.Position].YValue;

            return y;
        }


        public int GetNextSpace(ref Player player, Card card)
        {
            int n = player.Position;
            string actualSquare = card.CardType;

            if (actualSquare.Contains("double"))
            {
                actualSquare = actualSquare.Replace("double", "").ToLower();
                for (int i = player.Position+1; i < spaces.Length; i++)
                {
                    if (actualSquare.Equals(spaces[i].Square))
                    {
                        Console.WriteLine("in da double statement " + i);
                        player.Position = i;
                        n = player.Position;
                        break;
                    }

                    
                    
                }
                for (int i = player.Position +1; i < spaces.Length; i++)
                {
                    if (actualSquare.Equals(spaces[i].Square))
                    {
                        Console.WriteLine("in da double statement again " + i);
                        player.Position = i;
                        break;
                    }
                }
            }
            if (actualSquare.Contains("single"))
            {
                actualSquare = actualSquare.Replace("single", "").ToLower();
                for (int i = player.Position+1; i < spaces.Length; i++)
                {
                    if (actualSquare.Equals(spaces[i].Square))
                    {
                        Console.WriteLine("in da single statement " + i);
                        player.Position = i;
                        break;
                    }
                    
                }
            }
            if (actualSquare.Contains("special"))
            {
                for (int i = 0; i < spaces.Length; i++)
                {
                    if (actualSquare.Equals(spaces[i].Square))
                    {
                        Console.WriteLine("in da special statement " + i);
                        player.Position = i;
                        break;
                    }
                }
            }

            if (player.Position == n)
            {
                player.Position = 66;
            }

            return player.Position;
        }
    }
}