using System;
namespace OyunHw_5
{
    public class GameOwnerManager : IGameOwnerService
    {
        public void ownGame(Game game, Player player)
        {
            Console.WriteLine(player.PlayerName + ", " + game.GameName + " oyununu satin aldi.");
        }
    }
}
