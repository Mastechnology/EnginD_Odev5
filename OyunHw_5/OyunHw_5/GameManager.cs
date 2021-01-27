using System;
namespace OyunHw_5
{
    public class GameManager:IGameService
    {
        public GameManager()
        {
        }

        public void Add(Game game)
        {
            Console.WriteLine("Game Added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game Deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game Updated");
        }
    }
}
