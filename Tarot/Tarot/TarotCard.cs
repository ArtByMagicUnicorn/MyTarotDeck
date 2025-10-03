namespace Tarot
{
    public partial class TarotCard
    {
        public string Name { get; set; }
        public string Suit { get; set; }
        public int Number { get; set; }
        public List<CardMeaning> Meanings { get; set; } = new List<CardMeaning>();

        public TarotCard(string name, string suit, int number)
        {
            Name = name;
            Suit = suit;
            Number = number;
        }
    }
}
