using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.textRPG
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
        static void EnterGame()
        {
            //계속해서 반복 출력되는 코드
            while (true)
            {
                Console.WriteLine("게임에 접속했습니다.");

                Console.WriteLine("[1] 필드로 간다.");
                Console.WriteLine("[2] 로비로 돌아가기.");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        //EnterField();
                        break;

                    case "2":
                        /*break;*/
                        //브레이크 대신 리턴을 둠으로써 함수 차제를 끝낸다.
                        return;

                    default:
                        break;
                }

            }

        }
        static void Main(string[] args)
            {
                ClassType choise = ClassType.None;

                while (true)
                {
                    choise = ChoiseClass();
                    if (choise != ClassType.None)
                    {

                        Player player;
                        CreatPlayer(choise, out player);

                        Console.WriteLine($"hp 값:{player.hp} attack 값:{player.attack}");


                    //1. 게임에 들어가서 처리한다.
                          EnterGame();
                    //무한반복을 위해 break 삭제
                    /*break;*/
                      
                    }

                }
            }

       
    }
}


