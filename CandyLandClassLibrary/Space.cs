using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyland_Final
{
    public class Space
    {
        private string square;
        private int x, y;

        public Space(string name, int x, int y)
        {
            square = name;
            this.x = x;
            this.y = y;
        }

        public string Square
        {
            get 
            {
                return square;
            } 
            set
            {
                this.square = value;
            }
        }

        public int XValue
        {
            get
            {
                return x;
            }
            set
            {
                this.x = value;
            }
        }

        public int YValue
        {
            get
            {
                return y;
            }
            set
            {
                this.y = value;
            }
        }
    }
}
