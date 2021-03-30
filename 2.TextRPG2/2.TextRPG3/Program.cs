using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TextRPG2
{
    class Program
    {
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        }

        static ClassType ChoiseClass()
        {
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 아처");
            Console.WriteLine("[3] 메이지");

            ClassType choise = ClassType.None;
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    choise = ClassType.Knight;
                    break;
                case "2":
                    choise = ClassType.Archer;
                    break;
                case "3":
                    choise = ClassType.Mage;
                    break;

                default:
                    break;
            }
          
            return choise;
        }
        //플레이어를 받아서 작업한다.
        static void CreatPlayer(ClassType choise, out Player player)
        {

            player.hp = 0;
            player.attack = 0;
         
            switch (choise)
            {
                case ClassType.None:
                    break;
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    break;
            }
        }

        struct Player
        {
            public int hp;
            public int attack;
           
        }
        static void Main(string[] args)
        {
            ClassType choise = ClassType.None;

            while (true)
            {
                choise = ChoiseClass();
                if (choise != ClassType.None)
                {

                    /*  자료형이므로 구조체를 사용해 준다.
                     *  int hp;
                         int attack;*/
                    Player player;


                    /*     CreatPlayer(choise, out player.hp, out player.attack);*/


                        CreatPlayer(choise, out player);

                         Console.WriteLine($"hp 값:{player.hp} attack 값:{player.attack}");

              
                    break;
                }

            }
        }
    }
}
