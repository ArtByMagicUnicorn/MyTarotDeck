namespace Tarot
{
    public class TarotDeck
    {

        public List<TarotCard> TarotCards { get; set; }

        public TarotDeck()
        {
            TarotCards = TarotDeckFactory.CreateFullDeck();
        }
    }
}
