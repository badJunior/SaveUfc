using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {


            string[] fighters = new string[] { "Makhachev", " Tsarukyan", "Oliveira", "Geitji", "Porye", "Gamroth", "Chandler", "Dariush", "Physiology", "Holloway", };

            var cards = MakeCards(fighters);
            var cardscores = CalculateScores(cards);
            var cardWinners = DefineWinners(cardscores);
            ShowWinners(cardWinners);
           Console.ReadKey();   
        }

          static List<CardWinner> DefineWinners(List<CardScore> cardscores)
        {
           

            var cardWinners = cardscores.Select(cardscore => new CardWinner(cardscore)).ToList();

            
            return cardWinners;
        }
        
        static void ShowWinners(List<CardWinner> cardWinners)
        {

            foreach (var cardWinner in cardWinners)
            {
                Console.WriteLine($"кард:{cardWinner.NumberCard}, боец: {cardWinner.FighterName},количество побед {cardWinner.QuantityWinners}");
            }
        }

        static List<Card> MakeCards(string[] fighterNames)
        {
            var cards = new List<Card>();
            for (int i = 0; i < 5; i++)
            {
                

                cards.Add(new Card(i+1,20,fighterNames));
            } 
            return cards;

        }

        static List<CardScore> CalculateScores(List<Card> cards)
        {
            var cardscores = cards.Select(card => new CardScore(card)).ToList();

            return cardscores ;
        }
       
    }
    
}



