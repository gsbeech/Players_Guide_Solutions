using System;
using System.Collections.Generic;
using System.Text;

namespace Catacombs_Of_Class
{
    class Card
    {
        public CardColour Colour { get; }
        public CardRank Rank { get; }

        public Card(CardColour colour, CardRank rank)
        {
            Colour = colour;
            Rank = rank;
        }

        public bool IsFaceCard => Rank == CardRank.Ampersand || Rank == CardRank.Caret || Rank == CardRank.Dollar || Rank == CardRank.Percent;
        public bool IsNumberCard => !IsFaceCard;
    }

    enum CardColour
    {
        Unknown,
        Red,
        Green,
        Blue,
        Yellow
    }

    enum CardRank
    {
        Unknown,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Dollar,
        Percent,
        Caret,
        Ampersand

    }
}
