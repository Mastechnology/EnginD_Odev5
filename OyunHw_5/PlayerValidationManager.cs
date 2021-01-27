using System;
namespace OyunHw_5
{
    public class PlayerValidationManager:IPlayerValidationService
    {
        public PlayerValidationManager()
        {
        }

        public bool Validate(Player player)
        {
            if (player.PlayerBirthDay == "24.03.1999" && player.PlayerID == 1 && player.PlayerName == "Mehmet Faruk" && player.PlayerSurName == "Gul" && player.PlayerTC == "12345678910")
            {
                return true;
            }
            else
            {
                return false;
            }
   
        }
    }
}
