using System;

namespace OyunHw_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //player ekleme kismi
            Player player1 = new Player { PlayerID = 1, PlayerName = "Mehmet Faruk", PlayerSurName = "Gul", PlayerBirthDay = "24.03.1999", PlayerTC = "12345678910" };

            PlayerManager playerManager = new PlayerManager(new PlayerValidationManager());
            playerManager.Add(player1);

            //oyun ekleme kismi
            Game game1 = new Game { GameName = "GTA SAN ANDREAS", GameCost = 10, GameData = 5, GameRating = 9, GameType = "Free World" };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            //oyun satin alma kismi
            GameOwnerManager gameOwnerManager = new GameOwnerManager();
            gameOwnerManager.ownGame(game1, player1);

            //oyunu kampanya ile satin alma kismi
            Kampanya kampanya1 = new Kampanya { KampanyaName = "Efsane Cuma", KampanyaIndirimMiktar = "70" };
            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.KampanyaIleSatinAl(game1, kampanya1, player1);
        }
    }
}
