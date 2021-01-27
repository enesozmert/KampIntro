using GameHomework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Reposity
{
    class GameReposity
    {
        public List<Game> _games = new List<Game>();
        public Game _game = new Game() {Id=1,GName="GTA 5",Piece=10,Stock=100 };
        public Game _game1 = new Game() {Id=2,GName="GTA 4",Piece=9,Stock=101 };
        public Game _game2 = new Game() {Id=3,GName="GTA 3",Piece=8,Stock=102 };
    }
}
