using System;
using System.Collections.Generic;
using System.Text;
using GameCompany.Abstract;
using GameCompany.Entities;

namespace GameCompany.Concrete
{
    class PlayerManager:IPlayerManager
    {
        IPlayerCheckManager _playerCheckManager;

        public PlayerManager(IPlayerCheckManager playerCheckManager)
        {
            _playerCheckManager = playerCheckManager;

        }

        public void Register(Player player)
        {
            if (_playerCheckManager.CheckIfRealPerson(player))
            {
                 Console.WriteLine("Player registered : " + player.ID);

            }
            else
            {
                Console.WriteLine("Player not registered (not a real person) : " + player.ID);
            }
                           
        
        }

        public void Update(Player player)
        {
            Console.WriteLine("Player updated : " + player.ID);

        }
        public void Delete(Player player)
        {
            Console.WriteLine("Player deleted : " + player.ID);

        }

    }
}
