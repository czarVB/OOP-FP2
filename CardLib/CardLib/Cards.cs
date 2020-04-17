using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Cards.cs - A class defining the Cards object. Inherits
 * from CollectionBase and implements ICloneable.
 *
 * Author: Spence McComb - 100426427
 * Since: 2020/02/20
 * See: Beginning Visual C#® 2012 Programming
 */

namespace CardLib
{
    public class Cards : List<Card>, ICloneable
    {
        // Returns a deep copy of the object
        public object Clone()
        {
            Cards newCards = new Cards();
            foreach (Card sourceCard in this)
            {
                newCards.Add((Card)sourceCard.Clone());
            }
            return newCards;
        }

        // Adds a new card to the list
        public void Add(Card newCard)
        {
            this.Add(newCard);
        }

        // Removes an old card from the list
        public void Remove(Card oldCard)
        {
            this.Remove(oldCard);
        }

        // Property for a card from the card list
        public Card this[int cardIndex]
        {
            get
            {
                return (Card)this[cardIndex];
            }
            set
            {
                this[cardIndex] = value;
            }
        }

        /// <summary>
        /// Utility method for copying card instances into another Cards instance
        /// - used in Deck.Shuffle(). This implementation assumes that the source
        /// and target collections are of the same size.
        /// </summary>
        /// <param name="targetCards"></param>
        public void CopyTo(Cards targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        /// <summary>
        /// Checks to see if the Cards collection contains a particular card. This calls
        /// the Contains() method of the ArrayList for the collection, which you can
        /// access through the InnerList property.
        /// </summary>
        /// <param name="aCard"></param>
        /// <returns></returns>
        //public bool Contains(Card aCard)
        //{
        //    return InnerList.Contains(aCard);
        //}


        //gets a card based on int number
        public Card GetCard(int cardNum, Cards cards)
        {

            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                       "Value must be between 0 and 51."));
        }
    }
}

