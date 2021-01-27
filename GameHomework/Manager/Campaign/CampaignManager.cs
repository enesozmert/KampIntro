using System;
using System.Collections.Generic;
using System.Text;
using GameHomework.Entity;
using GameHomework.IEntity;
using GameHomework.IManager;
using GameHomework.Reposity;
namespace GameHomework.Manager
{
    class CampaignManager : ICampaignManager
    {
        CampaignsReposity _campaignsReposity = new CampaignsReposity();
        public void SaleCal(ICampaign campaign)
        {
            campaign.SelectGame.Price = campaign.SelectGame.Price - (campaign.SelectGame.Price * (campaign.Percent / 100));
        }

        public void SaleInf(ICampaign campaign)
        {
            _campaignsReposity._campaigns.Add(campaign);
            Console.WriteLine("%{0} Standart İndirim oluşturulmuştur.", campaign.Percent);
        }
    }
}
