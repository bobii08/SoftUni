using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rpg_Game_Team_Doldur.Interfaces
{
    public interface ICharacter : IAttack, IDestroyable
    {
        Position Position { get; }

        PictureBox SpritePictureBox { get; }

        Image Image { get; }
    }
}
