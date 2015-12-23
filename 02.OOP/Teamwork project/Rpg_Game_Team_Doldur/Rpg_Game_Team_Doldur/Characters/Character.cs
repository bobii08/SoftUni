namespace Rpg_Game_Team_Doldur.Characters
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Interfaces;

    public abstract class Character : ICharacter
    {
        private bool healthIsInitialized;
        private Position position;
        private int damage;
        private int health;

        protected Character(Position position, int health, int damage, Image image)
        {
            this.Position = position;
            this.Damage = damage;
            this.Health = health;
            this.IsAlive = true;
            this.Image = image;
            this.VisualizePlayer(Position.X, Position.Y, this.Image);
        }

        public Position Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public PictureBox SpritePictureBox { get; set; }

        public int Damage
        {
            get { return this.damage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("damage", "Damage cannot be negative!");
                }

                this.damage = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            set
            {
                if (!healthIsInitialized)
                {
                    if (value <= 0)
                    {
                        throw new ArgumentOutOfRangeException("health", "Health cannot be non-positive!");
                    }

                    this.health = value;
                    this.healthIsInitialized = true;
                }
                else
                {
                    if (value <= 0)
                    {
                        this.IsAlive = false;
                        this.health = 0;
                    }
                    else
                    {
                        this.health = value;
                    }
                }
            }
        }

        public Image Image { get; private set; }

        public bool IsAlive { get; private set; }

        public void VisualizePlayer(int posX, int posY, Image image)
        {
            this.SpritePictureBox = new PictureBox();
            this.SpritePictureBox.Image = image;
            this.SpritePictureBox.BackColor = Color.Transparent;
            this.SpritePictureBox.Width = 40;
            this.SpritePictureBox.Height = 40;
            this.SpritePictureBox.Show();
            this.SpritePictureBox.Location = new Point(posX, posY);
        }
        
        public abstract void Attack(ICharacter enemy);
    }
}
