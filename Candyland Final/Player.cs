using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyland_Final
{
    class Player
    {
        private int id;
        private string name;
        private int position;

        public Player()
        {

        }
        public Player(int id, string name, int position)
        {
            this.id = id;
            this.name = name;
            this.position = position;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
    }
}
