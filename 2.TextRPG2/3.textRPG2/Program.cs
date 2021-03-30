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

        //몬스터 타입 및 구조체 생성
        enum MonsterTpye
        {
            None = 0,
            Slime =1,
            Orc=2,
            Skeleton=3
        }
        struct Monster
        {
            public int hp;
            public int attack;
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

        static void CreatePlayer(ClassType choise, out Player player)
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
                Console.WriteLine("마을에 접속했습니다.");

                Console.WriteLine("[1] 필드로 간다.");
                Console.WriteLine("[2] 로비로 돌아가기.");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        EnterField();
                        break;

                    case "2":
                       
                        return;

                    default:
                        break;
                }

            }

        }

        private static void EnterField()
        {

            while (true)
            {
                Console.WriteLine("필드에 접속했습니다.");
                //랜덤으로 1-3몬스터 중 하나를 리스폰
                //[1] 전투모드 돌입
                //[2] 일정확률로 마을로 도망

                //몬스터 생성
                Monster monster;
                CreateRandomMonster(out monster);

                Console.WriteLine("[1] 전투모드 돌입");
                Console.WriteLine("[2] 일정확률로 마을로 도망");

                string input = Console.ReadLine();
                if (input == "1")
                {

                }
                else if(input=="2")
                {
                    return;
                }
            }
            
        }

        private static void CreateRandomMonster(out Monster monster)
        {
            //랜덤 타입의 몬스터 만든다.
            //슬라임 hp:20, attack=2 오크 hp:40, attack = 4, 스켈레톤 hp: 30, attack -3
            Random rand = new Random();
            int randMonster = rand.Next(1, 4);
            monster.hp = 0;
            monster.attack = 0;
            switch (randMonster)
            {
                case (int)MonsterTpye.Slime:
                    Console.WriteLine("슬라임이 스폰되었습니다.");
                    monster.hp = 20;
                    monster.attack = 2;

                    break;
                case (int)MonsterTpye.Orc:
                    Console.WriteLine("오크가 스폰되었습니다.");
                    monster.hp = 40;
                    monster.attack = 4;
                    break;
                case (int)MonsterTpye.Skeleton:
                    Console.WriteLine("스켈레톤이 스폰되었습니다.");
                    monster.hp = 30;
                    monster.attack = 3;
                    break;
                default:
                    
                    break;
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
                    CreatePlayer(choise, out player);

                    Console.WriteLine($"hp 값:{player.hp} attack 값:{player.attack}");


                    
                    EnterGame();
                   

                }

            }
        }


    }
}


