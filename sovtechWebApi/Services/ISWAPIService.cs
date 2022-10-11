using Newtonsoft.Json.Linq;

namespace sovtechWebApi.Services
{
    public interface ISWAPIService
    {
        Task<PeopleHeaderDTO> GetSWApiPeopleAsync();

        Task<PeopleHeaderDTO> SearchSWApiPeopleAsync(string? search);
    }
}
