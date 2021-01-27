using GameHomework.Entity;
using GameHomework.IManager;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GameHomework.Reposity;

namespace GameHomework.Manager
{
    class GameManager : IGameManager
    {
        GameReposity _gameReposity = new GameReposity();
        public void DeleteProduct(Game game)
        {
            _gameReposity._games.Remove(game);
            Console.WriteLine("Ürün silindi. Silinen ürün id = {0}", game.Id);
        }

        public void GetProduct(Game game)
        {
            _gameReposity._games.Add(game);
            game.Piece += 1;
            if (game.Stock < game.Piece)
            {
                Console.WriteLine("Ürün satın alınamadı.Depoda yer yok aga. Satılan ürün id = {0}", game.Id);
            }
            else if (game.Stock>game.Piece)
            {
                Console.WriteLine("Ürün satın alındı. Satılan ürün id = {0}", game.Id);
              
            }
            
        }

        public int NumberOfProducts()
        {
            return _gameReposity._games.Count;
        }

        public void SellProduct(User user, Game game)
        {
            game.Piece -= 1;
            Console.WriteLine("Ürün satıldı alıcı adı :{0} , Satılan oyun adı :{1}","Kalan ürün adedi :{2}", user.Name, game.GName,game.Piece);
            _gameReposity._games.Remove(game);
            _gameReposity._games.Add(game);
        }

        public List<Game> ToList()
        {
            return _gameReposity._games.ToList();
        }
    }
}
