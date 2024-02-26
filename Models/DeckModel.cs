namespace Deck_of_Cards_lab.Models
{
    public partial class DeckModel
    {
        public bool Success { get; set; }
        public string DeckId { get; set; }
        public long Remaining { get; set; }
        public bool Shuffled { get; set; }
    }

    public partial class DrawModel
    {
        public bool Success { get; set; }
        public string DeckId { get; set; }
        public List<Card> Cards { get; set; }
        public long Remaining { get; set; }
    }

    public partial class Card
    {
        public string Code { get; set; }
        public Uri Image { get; set; }
        public Images Images { get; set; }
        public string Value { get; set; }
        public string Suit { get; set; }
    }

    public partial class Images
    {
        public Uri Svg { get; set; }
        public Uri Png { get; set; }
    }
}
