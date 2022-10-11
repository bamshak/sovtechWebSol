using GraphQL;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using HotChocolate.Execution.Processing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using sovtechWebApi.Services;

namespace sovtechWebApi.GraphQL
{
    public static class QuerySearch
    {
        public static async Task<List<SearchResultDTO>> ProcessSearchAsync(IGraphQLClient graphQLClient, string search)
        {
            var resultlist = new List<SearchResultDTO>();
            //var graphQLClient = new GraphQLHttpClient("http://localhost:3000/graphql", new NewtonsoftJsonSerializer());
            var query = new GraphQLRequest
            {
                Query = @"query searchQuery($searchParam: String!){
                    jokesQuerySearch(query: $searchParam){    
                        total
                        results{
                                id
                                categories
                                uRL 
                                value
                                createdAt
                                iconUrl
                                updatedAt        
                                }
                        }

                    sWAPIPeopleSearch(search: $searchParam){
                        next
                        count
                        previous
                        results{
                                name
                                species
                                vehicles
                                starShips
                                created
                                edited
                                uRL
                                height
                                mass
                                hairColor
                                skinColor
                                eyeColor
                                birthYear
                                gender
                                homeWorld
                                films
                                }
                        }
                }",
                OperationName = "searchQuery",
                Variables = new { searchParam = search }
            };
            var response = await graphQLClient.SendQueryAsync<PairDTO>(query);


            var data = response.Data;
            //if (response.Is)
            //{
            //    ResultList = JsonConvert.DeserializeObject<JokeSearchDTO>(response.Content);
            //}
           // foreach (var item in response.Data)
            //{
                //resultlist.Add(new SearchResultDTO { SearchType = item[""] == "jokesQuerySearch" });
           // }

            return resultlist;
        }
    }
}
