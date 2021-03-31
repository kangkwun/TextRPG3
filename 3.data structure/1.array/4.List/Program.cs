using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.List
{
    class Program
    {
        static void Main(string[] args)
        {
            //타입을 꺽쇠 안에 넣어준다.
            List<int> list = new List<int>();

            //1. 빈상태에서 접근하면 오류가 난다.
            //list[0] = 1;


            //2. add 맨뒤에 숫자를 하나 추가한다.
            list.Add(1);

            
            //2.1 list의 길이는 count 이다.
            for (int i = 0; i < list.Count; i++)
            {
                list.Add(i);
            }

            foreach (int num in list)
            {
                Console.WriteLine(num);
            }

            //삽입,삭제

            //3. 중간삽입

            list.Insert(2, 999);

            //4. 삭제
            //4.1 처음 만난 3만 삭제한다.
            bool success= list.Remove(3);

            //4.2 인덱스 삭제
            list.RemoveAt(1);

            //4.3 전체삭제

            list.Clear();



        }
    }
}
