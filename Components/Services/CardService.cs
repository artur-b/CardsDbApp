using CardsDbApp.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CardsDbApp.Services
{
    public class CardService: ICardService
    {
        private readonly CardContext _context;

        public CardService(CardContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CardItem>> GetCards()
        {
            var cards = await _context.CardItems.ToListAsync();
            return cards;
        }
        public async Task<CardItem?> GetCard(long Id)
        {
            var card = await _context.CardItems.FindAsync(Id);
            return card; // throw NotFound Exception;
        }
    
    }
}