namespace _1.TextRPG2_2_
{
    public enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3

    }
    class Player : Creature
    {
        //플레이어 타입선언
        protected PlayerType type = PlayerType.None;
        //1. 상속 받아 처리하기 위해
        /*   protected int hp = 0;
           protected int attack = 0;
   */
        /*    public void SetInfo(int hp, int attack)
            {
                this.hp = hp;
                this.attack = attack;
            }

            public int GetHP() { return hp; }
            public int GetAttack() { return attack; }

            //2. 플레어 죽음과 데드도 만들어준다.

            public bool IsDead() { return hp <= 0; }

            public void OnDamaged(int damage)
            {
                hp -= damage;
                if (hp<0)
                {
                    hp = 0;
                }
            }*/

        //3. type을 받아야만 처리 가능하도록 설정
        //4. 자식의 타입으로 꼭 넣어야만 처리할 수 있도록 변경
        protected Player(PlayerType type) : base(CretureType.Player)
        {

            this.type = type;
        }
    }

    class Knight : Player
    {


        public Knight() : base(PlayerType.Knight)
        {
            //6. hp, attack 값을 넣어준다

            SetInfo(100, 10);
            /* type = PlayerType.Knight;*/
        }

    }

    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            SetInfo(75, 12);
            /*type = PlayerType.Archer;*/
        }
    }

    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            SetInfo(50, 15);
            /*type = PlayerType.Mage;*/
        }

    }
}
