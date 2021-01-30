using System;
using System.Collections.Generic;
using System.Text;
using GameCompany.Abstract;
using GameCompany.Entities;

namespace GameCompany.Concrete
{
    class CampaignManager : ICampaignManager
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign added : " + campaign.CampaignName);
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted : " + campaign.CampaignName);
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign updated : " + campaign.CampaignName);
        }
    }
}
