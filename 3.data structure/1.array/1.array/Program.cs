using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.array
{
    class Player
    {

    }
    class Monster
    {

    }


    class Program
    {
        Player player;
        Monster monster;
        Monster monster1;
        Monster monster2;
        // .....
        Monster monster1000;
        static void Main(string[] args)
        {
            int a;

            //1. 의미: int 형식을 여러개 가지고 있다.
            //2. 자료형의 갯수를 정하고 할당 해야 한다.
            int[] b = new int[5];

            b[0] = 10;
            b[1] = 20;
            b[2] = 30;
            b[3] = 40;
            b[4] = 50;

            //3. 더 많은 배열을 접근하려고 하면 오류가 발생한다.(index 오류)
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(b[i]);
            }

            //4. 배열의 길이 활용
            for (int i = 0; i <b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }

            //5. foreach문 사용
            
            for (int i = 0; i < b.Length; i++)
            {
                int b1 = b[i];
                Console.WriteLine(b1);
            }

            foreach (int b2 in b)
            {
                Console.WriteLine(b2);
            }

            //6. 한번에 할당
            int[] c = new int[5] { 10, 20, 30, 50, 40 };
            //6.1 길이 생략
            int[] c1 = new int[] { 10, 20, 30, 50, 40 };
            //6.2 할당자 생략
            int[] c2 = { 10, 20, 30, 50, 40 };


        }
    }
}
