using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ShortAttentionSpan : IPlayer
    {
        
        public int LastMovePlayer2;
        public int LastMovePlayer1;
        public int ShortAttentionMove;


        public int NextMove()
        {
            int nextMove = -1;
            switch (LastMovePlayer2)
            {
                case 0:
                    nextMove = 1;
                    ShortAttentionMove = 1;
                    break;
                case 1:
                    nextMove = 2;
                    ShortAttentionMove = 2;
                    break;
                case 2:
                    nextMove = 0;
                    ShortAttentionMove = 0;
                    break;
                default:
                    nextMove = -1;
                    break;
            }

            return nextMove;
        }


        public void SaveResult(int myMove, int otherMove)
        {
           
            LastMovePlayer2 = otherMove;
            LastMovePlayer1 = myMove;

        }
    }
}

