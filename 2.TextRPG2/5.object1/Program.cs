using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.object1
{
    //기사에 대한 설계도
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

    class Program
    {
        static void Main(string[] args)
        {
            //실제 생성
            Knight knight = new Knight();

            knight.hp = 100;
            knight.attack = 10;
            knight.Move();
            knight.Attack();

        }
    }
}
