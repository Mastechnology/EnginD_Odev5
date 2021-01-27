using System;
namespace OyunHw_5
{
    public class PlayerManager:IPlayerService
    {
        IPlayerValidationService _playerValidationService;

        public PlayerManager(IPlayerValidationService playerValidationService)
        {
            _playerValidationService = playerValidationService;
        }

        public void Add(Player player)
        {
            if(_playerValidationService.Validate(player) == true)
            {
                Console.WriteLine("Kayit Oldu");
            }
            else
            {
                Console.WriteLine("Dogrulama Basarisiz");
            }
        }

        public void Delete(Player player)
        {
             Console.WriteLine("Kayit Silindi");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Kayit Guncellendi");
        }
    }
}
