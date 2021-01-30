using System;
using System.Collections.Generic;
using System.Text;
using GameCompany.Abstract;
using GameCompany.Entities;

namespace GameCompany.Concrete
{
    class PlayerCheckManager : IPlayerCheckManager
    {
        
        public bool CheckIfRealPerson(Player player)
        {
                       
            return true;
        }

    }
}
