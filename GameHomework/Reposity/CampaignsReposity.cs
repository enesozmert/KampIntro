using System;
using System.Collections.Generic;
using System.Text;
using GameHomework.IEntity;
using GameHomework.Entity;
using GameHomework.IManager;
using System.Linq;
namespace GameHomework.Reposity
{
    class CampaignsReposity
    {
        public static readonly GameReposity _gameReposity = new GameReposity();
        public List<ICampaign> _campaigns = new List<ICampaign>() { };
        public Campaign campaign = new Campaign() {SelectGame=(Game)_gameReposity._game,UpDown=true,Id=1,Percent=10 };
    }
}
