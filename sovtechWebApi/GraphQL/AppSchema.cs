using GraphQL.Types;

namespace sovtechWebApi.GraphQL
{
    public class AppSchema : Schema
    {
        public AppSchema(IServiceProvider provider)
             : base(provider)
        {

        }
    }
}
