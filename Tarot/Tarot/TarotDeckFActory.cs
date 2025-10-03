namespace Tarot
{
        public class TarotDeckFactory
        {
            public static List<TarotCard> CreateFullDeck()
            {
                List<TarotCard> deck = new List<TarotCard>();

                TarotCard fool = new TarotCard("The Fool", "Major Arcana", 0);
                deck.Add(fool);
                TarotCard magician = new TarotCard("The Magician", "Major Arcana", 1);
                deck.Add(magician);
                TarotCard highPriestess = new TarotCard("The High Priestess", "Major Arcana", 2);
                deck.Add(highPriestess);
                TarotCard empress = new TarotCard("The Empress", "Major Arcana", 3);
                deck.Add(empress);
                TarotCard emperor = new TarotCard("The Emperor", "Major Arcana", 4);
                deck.Add(emperor);
                TarotCard hierophant = new TarotCard("The Hierophant", "Major Arcana", 5);
                deck.Add(hierophant);
                TarotCard lovers = new TarotCard("The Lovers", "Major Arcana", 6);
                deck.Add(lovers);
                TarotCard chariot = new TarotCard("The Chariot", "Major Arcana", 7);
                deck.Add(chariot);
                TarotCard strength = new TarotCard("Strength", "Major Arcana", 8);
                deck.Add(strength);
                TarotCard hermit = new TarotCard("The Hermit", "Major Arcana", 9);
                deck.Add(hermit);
                TarotCard wheelOfFortune = new TarotCard("Wheel of Fortune", "Major Arcana", 10);
                deck.Add(wheelOfFortune);
                TarotCard justice = new TarotCard("Justice", "Major Arcana", 11);
                deck.Add(justice);
                TarotCard hangedMan = new TarotCard("The Hanged Man", "Major Arcana", 12);
                deck.Add(hangedMan);
                TarotCard death = new TarotCard("Death", "Major Arcana", 13);
                deck.Add(death);
                TarotCard temperance = new TarotCard("Temperance", "Major Arcana", 14);
                deck.Add(temperance);
                TarotCard devil = new TarotCard("The Devil", "Major Arcana", 15);
                deck.Add(devil);
                TarotCard tower = new TarotCard("The Tower", "Major Arcana", 16);
                deck.Add(tower);
                TarotCard star = new TarotCard("The Star", "Major Arcana", 17);
                deck.Add(star);
                TarotCard moon = new TarotCard("The Moon", "Major Arcana", 18);
                deck.Add(moon);
                TarotCard sun = new TarotCard("The Sun", "Major Arcana", 19);
                deck.Add(sun);
                TarotCard judgement = new TarotCard("Judgement", "Major Arcana", 20);
                deck.Add(judgement);
                TarotCard world = new TarotCard("The World", "Major Arcana", 21);
                deck.Add(world);
                string[] suits = { "Wands", "Cups", "Swords", "Pentacles" };
                foreach (string suit in suits)
                {
                    for (int i = 1; i <= 14; i++)
                    {
                        string name;
                        switch (i)
                        {
                            case 1:
                                name = "Ace of " + suit;
                                break;
                            case 11:
                                name = "Page of " + suit;
                                break;
                            case 12:
                                name = "Knight of " + suit;
                                break;
                            case 13:
                                name = "Queen of " + suit;
                                break;
                            case 14:
                                name = "King of " + suit;
                                break;
                            default:
                                name = i.ToString() + " of " + suit;
                                break;
                        }
                        TarotCard card = new TarotCard(name, suit, i);
                        deck.Add(card);
                    }
                }

                return deck;



            }
        }
    }

