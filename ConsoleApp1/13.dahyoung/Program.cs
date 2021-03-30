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


        //하위 다형성을 위해 virtual을 사용한다.
        public virtual void Move()
        {
            Console.WriteLine("플레이어 이동");
        }
    }

    class Knight : Player
    {
        //override사용
        public override void Move()
        {
            Console.WriteLine("플레이어 이동");
        }
    }

    class Mage : Player
    {
        public int mp;

        //override사용
        public override void Move()
        {
            Console.WriteLine("플레이어 이동");
        }

    }

    class SuperKnight: Knight
    {
        //자손도 사용가능하다.
        public override void Move()
        {
            Console.WriteLine("superKnight 이동!");
        }
    }
    class Program
    {

        static void EnterGame(Player player)
        {

            player.Move();

            Mage mage = (player as Mage);
            if (mage != null)
            {
                mage.mp = 10;
              
            }
             
         
        }
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            EnterGame(mage);
        }
    }
}
