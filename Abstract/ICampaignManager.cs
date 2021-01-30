using System;
using System.Collections.Generic;
using System.Text;
using GameCompany.Entities;

namespace GameCompany.Abstract
{
    interface ICampaignManager
    {
        public void AddCampaign(Campaign campaign);
        public void DeleteCampaign(Campaign campaign);
        public void UpdateCampaign(Campaign campaign);
    }
}
