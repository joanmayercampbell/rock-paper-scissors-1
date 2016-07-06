using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{

    

    class StubbornAI : IPlayer
    {
      
        public int StubbornChoice;

        public StubbornAI(int favoriteMove)
        {
           
            StubbornChoice = favoriteMove;
        }


        public  int NextMove()
        {
            return StubbornChoice;
        }

        public void SaveResult(int myMove, int otherMove)
        {
            
        }
    }
}

