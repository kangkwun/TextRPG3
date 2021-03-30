namespace _1.TextRPG2_2_
{
    //1. enum 생성
    public enum CretureType
    {
        None,
        Player,
        Monster
    }
    class Creature
    {
        //3. 타입을 만들어 준다.
        CretureType type = CretureType.None;

        //4. 생성자 로 타입을 받는다.
        protected Creature(CretureType type)
        {
            this.type = type;
        }


        //2. player에서 가지고 온다.
        protected int hp = 0;
        protected int attack = 0;

        public void SetInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }

        public int GetHP() { return hp; }
        public int GetAttack() { return attack; }



        public bool IsDead() { return hp <= 0; }

        public void OnDamaged(int damage)
        {
            hp -= damage;
            if (hp < 0)
            {
                hp = 0;
            }
        }

    }
}
