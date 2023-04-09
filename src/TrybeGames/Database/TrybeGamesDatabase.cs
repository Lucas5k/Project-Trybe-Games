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
        var findAllGamesDeveloped = from game in Games
                                where game.DeveloperStudio == gameStudio.Id
                                select game;
        return (List<Game>) findAllGamesDeveloped.ToList();
    }

    public List<Game> GetGamesPlayedBy(Player player)
    {
        // Implementar
        var findAllGamesPlayed = from game in Games
                                      where game.Players.Contains(player.Id)
                                      select game;
        return (List<Game>) findAllGamesPlayed.ToList();
    }

    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        // Implementar
        var findAllGetGamesOwned = from game in Games
                            where game.Players.Contains(playerEntry.Id)
                            select game;

        return (List<Game>) findAllGetGamesOwned.ToList();
    }
}
