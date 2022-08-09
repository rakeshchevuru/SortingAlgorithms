using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented.Chess
{
    public abstract class Piece
    {

        private bool killed = false;
        private bool white = false;

        public Piece(bool white)
        {
            this.setWhite(white);
        }

        public bool isWhite()
        {
            return this.white == true;
        }

        public void setWhite(bool white)
        {
            this.white = white;
        }

        public bool isKilled()
        {
            return this.killed == true;
        }

        public void setKilled(bool killed)
        {
            this.killed = killed;
        }

        public abstract bool canMove(Board board, Box start, Box end);
    }
}
