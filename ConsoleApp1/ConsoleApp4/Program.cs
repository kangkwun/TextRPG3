using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Player // 부모 클래스, 혹은 기반 클래스
    {
        static public int counter = 1;
        public int id;
        public int hp;
        public int attack;

        public void Move()
        {
            Console.WriteLine("플레이어 움직임");
        }
        public void Attack()
        {
            Console.WriteLine("플레이어 공격");
        }


    }
    class Mage : Player // 자식 혹은 파생 클래스
    {

    }
    class Archer : Player
    {

    }

    class Knight : Player
    {        
    }
    class Program
    {
        static void Main(string[] args)
        {

            Knight knight = new Knight();

            knight.Move();
        }
    }
}
