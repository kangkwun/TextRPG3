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
            //값을 반환한다.
            return choise;
        }
        static void CreatPlayer(ClassType choise, out int hp, out int attack)
        {
            //1.3 out을 사용해 받는 값을 바로 사용한다
            hp = 0;
            attack = 0;
            //1.6 타입에 맞게 hp 및 attack 수정
            switch (choise)
            {
                case ClassType.None:
                    break;
                case ClassType.Knight:
                    hp = 100;
                    attack = 10;
                    break;
                case ClassType.Archer:
                    hp = 75;
                    attack = 12;
                    break;
                case ClassType.Mage:
                    hp = 50;
                    attack = 15;
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
                    //1. 캐릭터 생성
                    //1.1 직업마다 hp와 attack이 있다.
                    // 기사(100/10)  궁수(75/12) 법사(50/15)
                    int hp;
                    int attack;
                    // 1.2 CreatPlayer()를 한다.


                    /*   CreatPlayer(out hp, out attack);*/
                    //1.4 ClassType에 따르게 기사, 궁수, 법사를 받을 수 있또록 매개변수를 추가한다.

                    CreatPlayer(choise, out hp, out attack);

                    //1.7 hp 및 attack 확인

                    Console.WriteLine($"hp 값:{hp} attack 값:{attack}");

                    //2. 필드로 가서 몬스터랑 싸운다.
                    break;
                    }

                }
            }
    }
}
