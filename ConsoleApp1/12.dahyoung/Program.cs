using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.dahyoung
{
    class Player
    {
        protected int hp;
        protected int attatck;

        public void Move()
        {
            Console.WriteLine("플레이어 이동");
        }
    }

    class Knight : Player
    {
        public new void Move()
        {
            Console.WriteLine("플레이어 이동");
        }
    }

    class Mage : Player
    {
        public int mp;

        public new void Move()
        {
            Console.WriteLine("플레이어 이동");
        }

    }

    class Program
    {

        static void EnterGame(Player player)
        {
           

            Mage mage = (player as Mage);
            if (mage != null)
            {
                mage.mp = 10;
                mage.Move();
            }

            Knight knight = (player as Knight);
            if (mage != null)
            {
             
                knight.Move();
            }
        }
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            knight.Move();
            mage.Move();
        }
    }
}
