using System;
using System.Collections.Generic;
using System.Text;
using GameCompany.Entities;

namespace GameCompany.Abstract
{
    interface IPlayerManager
    {
        public void Register(Player player);
        public void Update(Player player);
        public void Delete(Player player);

    }
}
