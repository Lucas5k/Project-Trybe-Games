using System.Linq;
namespace TrybeGames;

public class TrybeGamesDatabase
{
    public List<Game> Games = new List<Game>();

    public List<GameStudio> GameStudios = new List<GameStudio>();

    public List<Player> Players = new List<Player>();

    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        // implementar
        var findAllGames = from game in Games
                                where game.DeveloperStudio == gameStudio.Id
                                select game;
        return (List<Game>)findAllGames;
    }

    public List<Game> GetGamesPlayedBy(Player player)
    {
        // Implementar
        throw new NotImplementedException();
    }

    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        // Implementar
        throw new NotImplementedException();
    }
}
