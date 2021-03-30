using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TextRPG2
{
    public enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer =2 ,
        Mage = 3

    }
    class Player
    {
        //플레이어 타입선언
        protected PlayerType type;
        //상속 받아 처리하기 위해
        protected int hp;
        protected int attack;
    }

    class Knight : Player
    {

        Knight()
        {
            type = PlayerType.Knight;
        }

    }

    class Archer : Player
    {
        Archer()
        {
            type = PlayerType.Archer;
        }
    }

    class Mage : Player
    {
        Mage()
        {
            type = PlayerType.Mage;
        }

    }
}
