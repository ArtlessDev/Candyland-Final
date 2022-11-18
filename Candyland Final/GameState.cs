using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyland_Final
{
    public class GameState
    {
        private Player[] players;
        private int currentTurn = 1;

        public Player[] Players
        {
            get { return this.players; }
            set { this.players = value; }
        }
        public int CurrentTurn
        {
            get { return this.currentTurn; }
            set { this.currentTurn = value; }
        }
        public Player GetFarthestPlayer()
        {
            Player farthestPlayer = this.players[0];
            for (int i = 0; i < this.players.Length; i++)
            {
                if (this.players[i].Position > farthestPlayer.Position)
                {
                    farthestPlayer = this.players[i];
                }
            }
            return farthestPlayer;
        }

        public void RotateTurns(int playerCount)
        {
            this.currentTurn++;
            if (this.currentTurn > playerCount)
            {
                this.currentTurn = 1;
            }
        }
    }
}
