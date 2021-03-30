using System;

namespace _1.TextRPG2_2_
{
    public enum GameMode
    {
        None,
        Lobby,
        Town,
        Field,
    }
    class Game
    {
        private GameMode mode = GameMode.Lobby;

        private Player player;
        private Random rand = new Random();

        private Monster monster;
        public void Process()
        {
            switch (mode)
            {
                case GameMode.None:
                    break;
                case GameMode.Lobby:
                    ProcessLobby();
                    break;
                case GameMode.Town:
                    ProcessTown();
                    break;
                case GameMode.Field:
                    ProcessField();
                    break;
                default:
                    break;
            }
        }

        private void ProcessField()
        {
            Console.WriteLine("필드에 입장했습니다.");
            Console.WriteLine("[1] 싸우기");
            Console.WriteLine("[2] 일정확률로 마을로 돌아가기");
            CreateRandomMonster();


            string input = Console.ReadLine();

            if (input == "1")
            {
                ProcessFight();
            }
            else if (input == "2")
            {
                TryEscape();
            }

        }

        private void TryEscape()
        {
            int randValue = rand.Next(0, 101);
            if (randValue < 33)
            {
                mode = GameMode.Town;
            }
            else
                ProcessFight();
        }

        private void ProcessFight()
        {
            while (true)
            {
                int damage = player.GetAttack();
                monster.OnDamaged(damage);

                if (monster.IsDead())
                {
                    Console.WriteLine("승리하였습니다.");
                    Console.WriteLine($"남은 체력{player.GetHP()}");
                    break;
                }

                damage = monster.GetAttack();
                player.OnDamaged(damage);
                if (player.IsDead())
                {
                    Console.WriteLine("패배하였습니다.");
                    mode = GameMode.Town;
                    break;
                }

            }
        }

        private void CreateRandomMonster()
        {
            int randValue = rand.Next(1, 4);

            switch (randValue)
            {
                case 1:
                    monster = new Slime();
                    Console.WriteLine("슬라임이 생성되었습니다.");
                    break;
                case 2:
                    monster = new Orc();
                    Console.WriteLine("오크가 생성되었습니다.");
                    break;
                case 3:
                    monster = new Skeleton();
                    Console.WriteLine("스켈레톤이 생성되었습니다.");
                    break;
                default:
                    break;
            }
        }

        public void ProcessTown()
        {
            Console.WriteLine("마을에 입장했습니다.");
            Console.WriteLine("[1]필드로 가기");
            Console.WriteLine("[2]로비로 가기");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    mode = GameMode.Field;
                    break;
                case "2":
                    mode = GameMode.Lobby;
                    break;
                default:
                    break;
            }

        }

        public void ProcessLobby()
        {
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    this.player = new Knight();
                    mode = GameMode.Town;
                    break;
                case "2":
                    this.player = new Archer();
                    mode = GameMode.Town;
                    break;
                case "3":
                    this.player = new Mage();
                    mode = GameMode.Town;
                    break;
                default:
                    break;
            }

        }
    }
}
