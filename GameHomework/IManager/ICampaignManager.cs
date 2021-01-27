using GameHomework.IEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.IManager
{
    interface ICampaignManager
    {
        void SaleCal(ICampaign campaign);
        void SaleInf(ICampaign campaign);
    }
}
