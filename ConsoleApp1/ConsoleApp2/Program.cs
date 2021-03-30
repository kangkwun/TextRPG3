using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Knight
    {
        //1. 필드 -> 인스턴스마다 다르게 동작할 수 있다.
        public int hp;
        public int attack;
        public int id;

        //2. static은 클래스에 종속적인 필드가 된다.
        //오로지 1개가 존재한다.
        //ex knight1, knight2 모두 공유하는 속성
        //ex) id 관리
        static public int Counter=1;

        public Knight()
        {
            id = Counter;
            Counter++;


        }

        static public void Test()
        {
            //오류 메시지 송출 this.id = 23;
            //공용함수는 각각의 객체에 접근하기 어렵다.
            Counter = 1;
            //static만 사용가능
        }
        //사용에제
        static public Knight CreatKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }
        public void Move()
        {
            Console.WriteLine("움직임");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            
            //1. 필드의 값은 인스턴스 마다 달라 질 수 있다.
            //붕어빵의 틀은 같아도 다 다르게 구어질 수 있다.
            Knight knight1 = new Knight();
            knight1.hp = 100;

            Knight knight2= new Knight();
            knight2.hp = 200;


            Knight knight4 = Knight.CreatKnight();
            //ex. console.WriteLine() -> 스테틱 타입이다.
            //ex. rand = 일반 타입

        }
    }
}
