namespace Rpg_Game_Team_Doldur.Dependencies
{
    using System.Drawing;

    public struct Tile
    {
        public Image TileImg { get; set; }
        public Point TileLocation { get; set; }
        public bool Walkable { get; set; }
    }
}
