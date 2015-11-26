using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GameEngine_TheSlum
{
    public class GameObject
    {
        protected GameObject(string id)
        {
            this.Id = id;
        }

        public string Id { get; private set; }
    }
}
