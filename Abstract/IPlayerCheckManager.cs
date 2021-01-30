using System;
using System.Collections.Generic;
using System.Text;
using GameCompany.Entities;

namespace GameCompany.Abstract
{
    interface IPlayerCheckManager
    {
        bool CheckIfRealPerson(Player player);
    }
}
