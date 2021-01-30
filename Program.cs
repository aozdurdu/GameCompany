using System;
using GameCompany.Abstract;
using GameCompany.Concrete;
using GameCompany.Entities;


namespace GameCompany
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player() { ID = 001, FirstName = "Jack", 
                LastName = "Silver", NationalID = 123456789, YearOfBirth = 1990};

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Player ID: " + player1.ID);
            Console.WriteLine("Player Name: " + player1.FirstName);
            Console.WriteLine("Player Surname: " + player1.LastName);
            Console.WriteLine("Player National ID: " + player1.NationalID);
            Console.WriteLine("Player Year of Birth: " + player1.YearOfBirth);
            Console.WriteLine("-----------------------------------");

            Game game1 = new Game() { ID = 100, GameName = "Star Wars Phantom",
                GamePrice = 500 };
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Game ID: " + game1.ID);
            Console.WriteLine("Game Name: " + game1.GameName);
            Console.WriteLine("Game Price: " + game1.GamePrice);
            Console.WriteLine("-----------------------------------");

            Campaign campaign1 = new Campaign() { ID = 1000, 
                CampaignName = "Black Friday", Discount = 100 };
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Campaign ID: " + campaign1.ID);
            Console.WriteLine("Campaign Name: " + campaign1.CampaignName);
            Console.WriteLine("Campaign Discount: " + campaign1.Discount);
            Console.WriteLine("-----------------------------------");


            PlayerManager playerManager = new PlayerManager(new PlayerCheckManager());

            playerManager.Register(player1);

            CampaignManager campaignManager = new CampaignManager();

            campaignManager.AddCampaign(campaign1);

            PurchaseManager pusrchaseManager = new PurchaseManager();

            pusrchaseManager.Purchase(player1, game1, campaign1);

            playerManager.Delete(player1);
            campaignManager.UpdateCampaign(campaign1);


        }
    }
}
