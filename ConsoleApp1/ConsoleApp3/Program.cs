using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Player // 부모 클래스, 혹은 기반 클래스
    {
        static public int counter = 1;
        public int id;
        public int hp;
        public int attack;

        public Player()
        {
            Console.WriteLine("플레이어 생성사 호출");
        }

        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("Player hp 생성자 호출!");
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
        int c;
        public Knight() : base(100)//부모 int 생성자 호출
        {
            this.c = 10;//자신의 변수 호출
            base.hp = 100;//부모의 변수 호출
            Console.WriteLine("Knight 생성자 호출!");

        }

        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }
   
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = Knight.CreateKnight();
        }
    }
}
