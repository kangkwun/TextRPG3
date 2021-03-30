namespace ConsoleApp1
{
    internal class Knight
    {
        public int hp;
        public int attack;

        //생성자
        //1.실행될 때 같이 할당된다.
        public Knight()
        {
            hp = 100;
            attack = 10;
            System.Console.WriteLine("생성자 호출!");
        }
        //2. 다중 생성자

        /*public Knight(int hp)*/
        public Knight(int inHp)
        {

            //3. 헷갈린다. 
            /*hp = hp;*/
            hp = inHp;
            //or
            //this는 자기 자신을 가르킨다.
            this.hp = inHp;
            System.Console.WriteLine("int 생성자 호출");

            //4. attack가 쓰이지 않음

        }
        //해결 this 키워드를 통해 빈 생성자를 호출한다.
      /*  public Knight(int hp) : this()
        {

        }*/

        
        public Knight(int hp, int attack):this(hp)
        {
            this.hp = hp;
            this.attack = attack;
            System.Console.WriteLine("int, int 생성자 호출");
        }
        

    }
}