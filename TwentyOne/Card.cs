using System;

namespace TwentyOne
{
    public struct Card
    {
        public string Suit { get; set; } // Fixed capitalization and syntax
        public string Face { get; set; } // Fixed capitalization and syntax

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit); // Fixed capitalization of "Face" and "Suit"
        }
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
