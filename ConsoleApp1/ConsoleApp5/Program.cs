using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    //은식성
    //자동차
    //핸들 페달 차문
        //전기장치 엔진 기름 <-> 외부노출 : 심각한 문제 발생 가능성

    class Knight
    {
        //접근 제한자(한정자)
            //public protectd private
        public int hp;// 모두 접근 가능

        //2. 클래스 내부만 사용가능
        private int attack;

        //3. 이렇게 사용하는 이유는 누가 접근해서 고쳤는지 알 수 있기 때문.
        public void SetAttack(int attakc)
        {
            this.attack = attack;
        }

        //1.남들이 접근하면 안되는 것을 풀어버릴 수 있다.
        public void SecretFunction()
        {
            
        }
        //4. 자식과 자신만 쓰기 가능
        protected int def;
    }

    class SuperKnight: Knight
    {
        void Test()
        {
            def = 10;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.hp = 1;

            //함수를 이용해 사용가능
            knight.SetAttack(10);

            Console.WriteLine();
            //안에 돌아가는 로직을 알지 못한채 사용하고 있다.
            
        }
    }
}
