using GameHomework.Entity;
using GameHomework.IEntity;
using GameHomework.IManager;
using GameHomework.Reposity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Manager.Campaign
{
    class StudentCampaignManager : ICampaignManager
    {
        CampaignsReposity _campaignsReposity = new CampaignsReposity();
        public void SaleCal(ICampaign campaign)
        {
            campaign.SelectGame.Price = campaign.SelectGame.Price - (campaign.SelectGame.Price * (campaign.Percent / 150));
        }

        public void SaleInf(ICampaign campaign)
        {
            _campaignsReposity._campaigns.Add(campaign);
            Console.WriteLine("%{0} Öğrenci İndirim oluşturulmuştur.", campaign.Percent);
        }
    }
}
