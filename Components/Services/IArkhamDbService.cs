using CardsDbApp.Models;

namespace CardsDbApp.Services
{
    public interface IArkhamDbService
    {
        Task<ArkhamDbApiResponse?> GetCardObject(string code);
    }
}