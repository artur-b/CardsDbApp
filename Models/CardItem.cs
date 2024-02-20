namespace CardsDbApp.Models
{
	public class CardItem
	{
        public long Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public int Cost { get; set; }
		public string Color { get; set; } = String.Empty;
		public string AHDBCode { get; set; } = String.Empty;
	}
}

