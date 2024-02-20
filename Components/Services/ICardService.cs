using CardsDbApp.Models;

namespace CardsDbApp.Services
{
    public interface ICardService
    {
        Task<IEnumerable<CardItem>> GetCards();
        Task<CardItem?> GetCard(long Id);
    }
}