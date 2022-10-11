using GraphQL.Types;
using sovtechWebApi.Services;

namespace sovtechWebApi.GraphQL
{
    public class JokesType : ObjectGraphType<JokesDTO>
    {
        public JokesType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Jokes ID");
            Field(x => x.UpdatedAt).Description("Date of Update.");
            Field(x => x.IconUrl).Description("Icon URL.");

            Field(x => x.URL).Description("URL.");
            Field(x => x.CreatedAt).Description("Date Joke was created.");
            Field(x => x.Categories).Description("List of Categories.");
            Field(x => x.Value).Description("Joke value.");
            //Field(x => x.UpdatedAt).Description("Date of Update.");
            //Field(x => x.IconUrl).Description("Icon URL.");
        }
    }
}
