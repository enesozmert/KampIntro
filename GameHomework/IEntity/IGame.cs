using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Entity
{
    public interface IGame
    {
        public int Id { get; set; }
        public string GName { get; set; }
        public int Piece { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public IUser User { get; set; }
    }
}
