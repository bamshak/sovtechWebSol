using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using sovtechWebApi.GraphQL;
using sovtechWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(d => d.SwaggerDoc("v1", new()
{
    Version = "v1",
    Title = "Web API Task",
    Description = "WebAPI for Chuck Norris and Star Wars API",
    Contact = new Microsoft.OpenApi.Models.OpenApiContact
    {
        Name = "David Meshak", 
        Email = "djmeshak@yahoo.com"
    }
}));
builder.Services.AddScoped<IChuckNorrisService, ChuckNorrisService>();//
builder.Services.AddScoped<ISWAPIService, SWAPIService>();
builder.Services.AddGraphQLServer().AddQueryType<Query>();
builder.Services.AddScoped<IGraphQLClient>(s => new GraphQLHttpClient("http://localhost:3000/graphql/", new NewtonsoftJsonSerializer()));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/chuck/categories", async (IChuckNorrisService service) =>
    await service.AllJokesCategoriesAsync());

app.MapGet("/swapi/people", async (ISWAPIService serv) =>
    await serv.GetSWApiPeopleAsync());

app.MapGet("/chuck/randomJoke/{category}", async (IChuckNorrisService service, string category) =>
   await service.GetRandomJokesByCategoriesAsync(category));

//app.MapPost("/search/{query}", async (IChuckNorrisService service, string query) =>
//   await service.SearchRandomJokes(query));

app.MapGet("/search/{search}", async (IGraphQLClient graphQLClient,string search) =>
   await QuerySearch.ProcessSearchAsync(graphQLClient, search));

app.MapGraphQL();
app.Run("http://localhost:3000");
