using System;
using System.Collections.Generic;
using System.Text;
using GameCompany.Entities;


namespace GameCompany.Abstract
{
    interface IPurchaseManager
    {
        void Purchase(Player player, Game game, Campaign campaign);
    }
}
