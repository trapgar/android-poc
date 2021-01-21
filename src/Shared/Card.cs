using System.Diagnostics;
using System.Linq;

namespace Shared
{
    enum Suit
    {
        Spades,
        Hearts,
        Clubs,
        Diamonds
    }

    [DebuggerDisplay(@"\{{ToString(),nq}\}")]
    class Card
    {
        public Suit Suit { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return this.Value switch
            {
                1 => $"A of {this.Suit}",
                11 => $"J of {this.Suit}",
                12 => $"Q of {this.Suit}",
                13 => $"K of {this.Suit}",
                _ => $"{this.Value} of {this.Suit}"
            };
        }
    }
}
