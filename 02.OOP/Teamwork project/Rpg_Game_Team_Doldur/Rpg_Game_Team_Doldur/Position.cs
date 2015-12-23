namespace Rpg_Game_Team_Doldur
{
    public struct Position
    {
        private int x;
        private int y;

        public Position(int x, int y)
            :this()
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get { return this.x; }
            private set { this.x = value;}
        }

        public int Y
        {
            get { return this.y; }
            private set { this.y = value; }
        }
    }
}
