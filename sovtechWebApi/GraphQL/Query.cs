using sovtechWebApi.Services;

namespace sovtechWebApi.GraphQL
{
    public class Query
    {
        public string Hello(string david) => $"World {david}";
        public async Task<JokesDTO> RandomJokesByCategories([Service] IChuckNorrisService repo, string categoryid) =>
          await repo.GetRandomJokesByCategoriesAsync(categoryId: categoryid);

        public async Task<JokeSearchDTO> JokesQuerySearch([Service] IChuckNorrisService repo, string query) =>
         await repo.SearchRandomJokes(query: query);

        public async Task<PeopleHeaderDTO> SWAPIPeopleSearch([Service] ISWAPIService repo, string search) =>
         await repo.SearchSWApiPeopleAsync(search: search);
    }
}
