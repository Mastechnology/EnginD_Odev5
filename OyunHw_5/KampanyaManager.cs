using System;
namespace OyunHw_5
{
    public class KampanyaManager:IKampanyaService
    {
        public void KampanyaIleSatinAl(Game game, Kampanya kampanya, Player player)
        {
            Console.WriteLine(player.PlayerName + " adli kullanici " + game.GameName + " oyununu %" + kampanya.KampanyaIndirimMiktar + " indirim miktari ile " + kampanya.KampanyaName + " kampanyasindan faydalanarak bu oyunu satin almis bulunmaktadir.");
        }
    }
}
