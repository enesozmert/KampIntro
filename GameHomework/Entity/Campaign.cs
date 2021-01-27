using System;
using System.Collections.Generic;
using System.Text;
using GameHomework.IEntity;
namespace GameHomework.Entity
{
    class Campaign : ICampaign

    {
        public int Percent { get ; set ; }
        public bool UpDown { get ; set ; }
        public Game SelectGame { get ; set ; }
        public int Id { get; set; }
    }
}
