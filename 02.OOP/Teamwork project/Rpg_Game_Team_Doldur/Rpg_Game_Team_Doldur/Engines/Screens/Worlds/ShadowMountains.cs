namespace Rpg_Game_Team_Doldur.Engines.Screens.Worlds
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Dependencies;
    using Characters.PlayerCharacters;
    using Characters.Enemies;

    public partial class ShadowMountains : Form
    {
        private Graphics graphics;
        private int mapX;
        private int mapY;
        public Image mapImage;
        public List<Tile> mapTiles;
        PictureBox worldMapSpritePb;
        private bool inCombat;
        private TextBoxReader textBoxReader;
        private EnemyHandler enemyHandler;
        private IEnumerable<Enemy> enemyList;

        public ShadowMountains(Player player)
        {
            InitializeComponent();
            this.Player = player;
            this.mapTiles = new List<Tile>();
            this.enemyList = new List<Enemy>();
            InitializeField();
            this.Draw();
        }

        public Player Player { get; private set; }

        public void InitializeField()
        {
            this.worldMapSpritePb = new PictureBox();
            this.worldMapSpritePb.Width = this.Width;
            this.worldMapSpritePb.Height = this.Height;
            this.worldMapSpritePb.BackColor = Color.Transparent;
            this.worldMapSpritePb.Parent = this;
            this.worldMapSpritePb.BorderStyle = BorderStyle.None;

            this.inCombat = false;

            this.textBoxReader = new TextBoxReader();

            this.LoadNewMap(0, 0);

            this.Controls.Add(this.Player.SpritePictureBox);
            this.Player.SpritePictureBox.Parent = this.worldMapSpritePb;
        }

        private void LoadNewMap(int xMove, int yMove)
        {
            this.RemoveEnemies();

            mapX += xMove;
            mapY += yMove;
            this.LoadMap(mapX + " " + mapY);

            // LoadMonstersOnMap();
            //LoadFriendlyNPCsOnMap();
        }

        public void LoadMap(string mapName)
        {
            mapTiles.Clear();

            StreamReader reader = new StreamReader(@"..\..\Resources\Maps\ShadowMountains\" + mapName + ".txt");
            this.enemyHandler = new EnemyHandler();
            int y = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                
                for (int x = 0; x < line.Length; x++)
                {
                    Tile t = new Tile();

                    t.TileLocation = new Point(x * 40, y * 40);

                    if (line[x].ToString() == "1")
                    {

                        t.TileImg = Properties.Resources.GrassTile;
                        t.Walkable = true;
                    }
                    if (line[x].ToString() == "0")
                    {
                        t.TileImg = Properties.Resources.WaterTile;
                        t.Walkable = false;
                    }

                    mapTiles.Add(t);
                }

                y++;
            }

            this.enemyHandler.LoadEnemies(mapName);
            this.enemyList = this.enemyHandler.EnemyList;
            this.LoadEnemies();

            reader.Close();
        }

        private void LoadEnemies()
        {
            foreach (var enemy in this.enemyList)
            {
                if (enemy.IsAlive)
                {
                    this.Controls.Add(enemy.SpritePictureBox);
                    enemy.SpritePictureBox.Parent = this.worldMapSpritePb;
                }
            }
        }

        private void RemoveEnemies()
        {
            foreach (var enemy in this.enemyList)
            {
                this.Controls.Remove(enemy.SpritePictureBox);
                enemy.SpritePictureBox.Parent = null;
            }
        }

        private void Draw()
        {
            Graphics device;
            Image img = new Bitmap(this.Width, this.Height);
            device = Graphics.FromImage(img);

            this.DrawMap(device);
            // playerParty.partySprite.Draw(device);

            //foreach (WorldMapMonster m in worldMapMonsters)
            //{
            //    //check if monster is alive before drawing
            //    if (m.alive)
            //        m.Draw(device);
            //}

            //
            //foreach (WorldMapSprite m in friendlyNPCs)
            //{
            //    m.Draw(device);
            //}

            if (textBoxReader.open)
            {
                device.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(0, 300, this.Height, this.Width));
                device.DrawString(textBoxReader.currentText, new Font("arial", 10),
                    new SolidBrush(Color.White), new Point(5, 305));
            }

            this.worldMapSpritePb.Image = img;
        }

        public void DrawMap(Graphics device)
        {
            foreach (Tile tile in mapTiles)
            {
                device.DrawImageUnscaledAndClipped(tile.TileImg, new Rectangle(tile.TileLocation, new Size(40, 40)));
                //device.DrawImage(t.img, t.loc);
            }
        }

        public bool GetWalkableAt(Point location)
        {
            foreach (Tile tile in mapTiles)
            {
                if (tile.TileLocation == location && tile.Walkable)
                {
                    return true;
                }
            }

            return false;
        }

        private void ShadowMountains_KeyDown(object sender, KeyEventArgs e)
        {
            if (!inCombat)
            {
                Point p = new Point(0, 0);

                if (e.KeyCode == Keys.Left)
                {
                    p = new Point(-40, 0);
                }
                if (e.KeyCode == Keys.Right)
                {
                    p = new Point(40, 0);
                }
                if (e.KeyCode == Keys.Up)
                {
                    p = new Point(0, -40);
                }
                if (e.KeyCode == Keys.Down)
                {
                    p = new Point(0, 40);
                }

                //
                Point potentialMove = new Point(p.X + this.Player.SpritePictureBox.Location.X,
                    p.Y + this.Player.SpritePictureBox.Location.Y);


                if (this.GetWalkableAt(potentialMove))
                {
                    this.Player.Move(p.X, p.Y);
                }
                else
                {
                    //Load new map if possible
                    if (potentialMove.X > this.Width - 80)
                    {
                        LoadNewMap(1, 0);
                        this.Player.Move((this.Width * (-1)), 0);
                    }
                    if (potentialMove.X < 0)
                    {
                        this.Player.Move(0, 0);
                    }
                    if (potentialMove.Y < 0)
                    {
                        this.Player.Move(0, 0);
                    }
                    if (potentialMove.Y > this.Height)
                    {
                        this.Player.Move(0, this.Height);
                    }
                }

                foreach (var enemy in this.enemyList)
                {
                    if ((this.Player.Position.X == enemy.Position.X) && (this.Player.Position.Y == enemy.Position.Y) && enemy.IsAlive)
                    {
                        var collisionDetection = new CollisionDetection(this);
                        collisionDetection.DetectCollision(this.Player, enemy);
                    }
                }

                //foreach (var enemy in collisionDetection.UnitsInMap)
                //{
                //    if (!(enemy is Player))
                //    {
                //        collisionDetection(this.player, enemy);
                //    }
                //}
            }
            else
            {
                //    //Use monsterInCombat variable to remove correct sprite
                //    //If the combat GUI has exited combat, remove our enemy sprite
                //    if (!combatGUI.inCombat)
                //    {
                //        monsterInCombat.alive = false;
                //        KillMonsterInList(monsterInCombat);
                //        inCombat = false;
                //    }
                //}

                //DetectCollision();
            }

            Draw();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

