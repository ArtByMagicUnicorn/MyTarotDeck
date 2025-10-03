using System.ComponentModel;

namespace Tarot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa ny kortlek via fabrik
            TarotDeck minKortlek = new TarotDeck();

            //Slumpa fram ett kort
            Random random = new Random();
            int card_index = random.Next(0, minKortlek.TarotCards.Count);
            
            //Dra kortet
            TarotCard slumpatKort = minKortlek.TarotCards[card_index];
            Console.WriteLine($"Du har dragit kort: {slumpatKort.Name}");
        }
    }

    public class CardMeaning
    {
        public string Position { get; set; }
        public string Text { get; set; }
        public CardMeaning(string position, string text)
        {
            Position = position;
            Text = text;
        }
    }
}
