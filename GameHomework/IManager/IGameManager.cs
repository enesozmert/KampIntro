using GameHomework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.IManager
{
    interface IGameManager
    {
        void SellProduct(User user, Game game);
        void GetProduct(Game game);
        void DeleteProduct(Game game);
        int NumberOfProducts();
        List<Game> ToList();
    }
}
