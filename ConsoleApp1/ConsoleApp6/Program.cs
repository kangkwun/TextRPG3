using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //은닉성

    class Player
    {
        protected int hp;
        protected int attack;
    }

    class Knight : Player
    {

    }

    class Mage : Player
    {
        public int mp;
    }

    class Program
    {
        //이전의 코딩
        //단점 -> 비슷한 코드가 계속 반복된다 -> 비효율적
        /*        
                static void EnterGame(Knight knight)
                {

                }

                static void EnterGame(Mage mage)
                {

                }*/

        //해결
        //문제가 없이 knight와 mage가 매개변수로 들어간다.
        //but mage의 mp를 사용할 수 없다.
        //Mage 타입 -> Player 타입으로 변환가능
        //Player 타입 -> mage 타입 변환은 때때로 가능
       
        static void EnterGame(Player player)
        {
            //컴파일 단계는 아니지만 실행하면 오류가 생긴다.
            Player magePlayer = new Player();
            Mage mage1 = (Mage)magePlayer;
            mage1.mp = 10;

            /*Mage mage = (Mage)magePlayer;
                mage2.mp = 10;*/

            //해결법 1 is 사용
            bool isMage = (player is Mage);
            if (isMage)
            {
                Mage mage2 = (Mage)player;
                mage2.mp = 10;
                Console.WriteLine("생성");
            }

            //해결법 2 as 사용
            Mage mage3 = (player as Mage);

            if (mage3 != null)
            {
                mage3.mp = 10;
                Console.WriteLine("생성");
            }
        }
        static void Main(string[] args)
            
        {
            //힙 메모리에 Knight가 생성되고
            //스텍 메모리에는 knight가 생성된 상태
            Knight knight = new Knight();
            Mage mage = new Mage();   


            EnterGame(knight);
            EnterGame(mage);


        }
    }
}
