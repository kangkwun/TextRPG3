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

 
        enum MonsterTpye
        {
            None = 0,
            Slime = 1,
            Orc = 2,
            Skeleton = 3
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
        static void EnterGame(ref Player player)
        {
           
            while (true)
            {
                Console.WriteLine("마을에 접속했습니다.");

                Console.WriteLine("[1] 필드로 간다.");
                Console.WriteLine("[2] 로비로 돌아가기.");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        //매개변수로 받은 플레이어를 다시 입력한다.
                        EnterField(ref player);
                        break;

                    case "2":

                        return;

                    default:
                        break;
                }

            }

        }

        //EnterGame에서 가져온 player를 매개변수로 사용한다.
        private static void EnterField(ref Player player)
        {

            while (true)
            {
                Console.WriteLine("필드에 접속했습니다.");
              
                Monster monster;
                CreateRandomMonster(out monster);

                Console.WriteLine("[1] 전투모드 돌입");
                Console.WriteLine("[2] 일정확률로 마을로 도망");

                // 전투를 만들어준다.
                //몬스터와 플레이어가 한대 씩 주고 받는다.
                string input = Console.ReadLine();
                if (input == "1")
                {
                    //main의 플레이어를 사용하기 위해 EnterGame의 매개변수로 player 생성
                    Fight(ref player,ref monster);

                }
                else if (input == "2")
                {
                    //33%미만이면 도망, 아니면 싸워야함.
                    Random rand = new Random();
                    int randValue = rand.Next(0, 101);

                    if (randValue<33)
                    {
                        Console.WriteLine("도망치는데 성공했습니다.");
                        break;
                    }
                    else{

                        Fight(ref player, ref monster);
                    }

                  
                }
            }

        }

        static void Fight(ref Player player, ref Monster monster)
        {
            while (true)
            {
                //플레이어가 몬스터 공격
                monster.hp -= player.attack;

                if (monster.hp<=0)
                {
                    Console.WriteLine("승리하였습니다.");
                    Console.WriteLine($"남은체력{player.hp}");
                    break;
                }

                //몬스터 반격
                player.hp -= monster.attack;

                if (player.hp <= 0)
                {
                    Console.WriteLine("패배하였습니다.");
                    break;
                }
            }
        }

        private static void CreateRandomMonster(out Monster monster)
        {
          
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



                    EnterGame(ref player);


                }

            }
        }


    }
}


