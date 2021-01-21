using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Shared
{
    [DebuggerDisplay(@"Count = {cards.Count}")]
    class Deck : IList<Card>
    {
        private List<Card> cards;

        public Card this[int index]
        {
            get => cards[index];
            set => cards[index] = value;
        }

        public Deck()
        {
            this.cards = Enum.GetValues(typeof(Suit))
                .Cast<Suit>()
                .SelectMany(s => Enumerable.Range(1, 13).Select(i => new Card { Suit = s, Value = i }))
                .ToList();
        }

        public void Shuffle()
        {
            var randy = new Random();

            this.cards = this.cards
                .OrderBy(c => randy.Next())
                .ToList();
        }

        // IList<Card> implementations
        public int Count => cards.Count;
        public bool IsReadOnly => false;

        public void Add(Card card) => cards.Add(card);
        public void Clear() => cards.Clear();
        public bool Contains(Card card) => cards.Contains(card);
        public void CopyTo(Card[] array, int arrayIndex) => cards.CopyTo(array, arrayIndex);
        public IEnumerator<Card> GetEnumerator() => cards.GetEnumerator();
        public int IndexOf(Card card) => cards.IndexOf(card);
        public void Insert(int index, Card item) => cards.Insert(index, item);
        public bool Remove(Card card) => cards.Remove(card);
        public void RemoveAt(int index) => cards.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
