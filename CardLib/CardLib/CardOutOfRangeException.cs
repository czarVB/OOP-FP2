using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public class CardOutOfRangeException : Exception
    {
        private Cards deckContents;

        // Property for the attribute - getter only
        public Cards DeckContents
        {
            get
            {
                return deckContents;
            }
        }

        // Extends the base class exception: tells the user the limit is 52 cards in a deck
        public CardOutOfRangeException(Cards sourceDeckContents) :
            base("There are only 52 cards in the deck.")
        {
            deckContents = sourceDeckContents;
        }

    }
}
