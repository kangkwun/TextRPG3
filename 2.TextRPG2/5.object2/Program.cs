using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.object2
{
    class Knight
    {
        public int hp;
        public int attack;

        public void Move()
        {
            Console.WriteLine("Knight move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }

    }


    struct Mage
    {
        public int hp;
        public int attack;
    }
    class Program
    {
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }

        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }


        static void Main(string[] args)
        {
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;
            KillMage(mage);
            Console.WriteLine($"메이지의 체력{mage.hp}");


            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;
            KillKnight(knight);
            Console.WriteLine($"나이트의 체력{knight.hp}");
        }
    }
}
