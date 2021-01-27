using System;
namespace OyunHw_5
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
