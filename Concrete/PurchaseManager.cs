using System;
using System.Collections.Generic;
using System.Text;
using GameCompany.Abstract;
using GameCompany.Entities;

namespace GameCompany.Concrete
{
    class PurchaseManager : IPurchaseManager
    {
        public void Purchase(Player player, Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " price is: " + game.GamePrice + "\nWith " + campaign.CampaignName + " campaign, the discount is: " + campaign.Discount);
            Console.WriteLine(player.FirstName + " is purchased for: " + (game.GamePrice-campaign.Discount));
        }
    }
}
