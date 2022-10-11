using GraphQL.Types;
using sovtechWebApi.Services;

namespace sovtechWebApi.GraphQL
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IChuckNorrisService repository, string categoryid)
        {
             Field<ListGraphType<JokesType>>("RandomJokes",
               resolve: context => repository.GetRandomJokesByCategoriesAsync(categoryid).Result);
        }
    }
}
