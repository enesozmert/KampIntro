using GameHomework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.IEntity
{
    interface ICampaign
    {
        public int Id { get; set; }
        public int Percent { get; set; }
        public bool UpDown { get; set; }
        public Game SelectGame { get; set; }
    }
}
