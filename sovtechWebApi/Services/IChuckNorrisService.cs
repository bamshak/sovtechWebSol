namespace sovtechWebApi.Services
{
    public interface IChuckNorrisService
    {
        Task<List<string>> AllJokesCategoriesAsync();
        Task<JokesDTO> GetRandomJokesByCategoriesAsync(string categoryId);

        Task<JokeSearchDTO> SearchRandomJokes(string? query);
    }
}
