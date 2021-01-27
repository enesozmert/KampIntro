using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Entity
{
    class Game : IGame
    {
        public int Id { get ; set ; }
        public string GName { get ; set ; }
        public int Piece { get ; set ; }
        public int Stock { get ; set ; }
        public IUser User { get ; set ; }
        public int Price { get ; set ; }
    }
}
