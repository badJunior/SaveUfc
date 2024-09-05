﻿namespace ConsoleApp2
{
    class CardScore
    {
        public List<Score> Scores { get; set; }
        public Card Card { get; set; }
        public CardScore(Card card)
        {
           
            var scores = card.Fights.GroupBy(fight => fight.Winner).Select(group => 
            {
                Score score = new Score(group.Key);
                score.QuantityWins = group.Count();
                return score;
            }).ToList();

            Scores = scores;
            Card = card;
        }


    }
}