using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // for images

/**
 * Card.cs - A class defining the Card object. Implements 
 * the ICloneable interface.
 *
 * Author: Spence McComb - 100426427
 * Written: 2020/02/14
 * Since: 2020/03/13
 * See: Beginning Visual C#® 2012 Programming
 */

namespace CardLib
{
    public class Card : ICloneable, IComparable
    {
        /*
         * PROPERTIES
         */
         
        // Suit property, used to get or set the Suit
        protected Suit mySuit;
        public Suit Suit
        {
            get { return mySuit; }
            set { mySuit = value; }
        }

        // Rank property, used to get or set the Rank
        protected Rank myRank;
        public Rank Rank
        {
            get { return myRank; }
            set { myRank = value; }
        }

        // CardValue property, used to get or set the Card's value
        protected int myValue;
        public int CardValue
        {
            get { return myValue; }
            set { myValue = value; }
        }

        // Alternate value property, used to set or get an alternate value for certain games (nullable)
        protected int? altValue = null;
        public int? AlternateValue
        {
            get { return altValue; }
            set { altValue = value; }
        }

        // FaceUp property, used to get or set whether the card is face up
        protected bool faceUp = false;
        public bool FaceUp
        {
            get { return faceUp; }
            set { faceUp = value; }
        }

        protected bool lastCard = false;
        public bool LastCard
        {
            get { return lastCard; }
            set { lastCard = value; }
        }

        // Flag for trump usage. If true, trumps are valued higher than other suits
        public static bool useTrumps = false;

        // Set the default trump suit if useTrumps is true
        public static Suit trump = Suit.Clubs;

        // Indicates whether aces are considered high value or low
        public static bool isAceHigh = true;

        // Returns a shallow copy of the object
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /*
         * CONSTRUCTORS
         */

        /// <summary>
        /// Card constructor
        /// Initializes the playing card object. By defualt, card is face down with no alternate value.
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="suit"></param>
        public Card(Rank rank = Rank.Ace, Suit suit = Suit.Hearts)
        {
            this.myRank = rank;
            this.mySuit = suit;
            this.myValue = (int)rank;
        }


        /*
         * OPERATOR OVERLOADS
         */

        // Equality operator
        public static bool operator ==(Card left, Card right)
        {
            return (left.CardValue == right.CardValue);
        }

        // Inequality operator
        public static bool operator !=(Card left, Card right)
        {
            return (left.CardValue != right.CardValue);
        }

        // Another equality check
        public override bool Equals(object obj)
        {
            return (this.CardValue == ((Card)obj).CardValue);
        }

        // Determines if a card is superior than another
        public static bool operator >(Card left, Card right)
        {
            return (left.CardValue > right.CardValue);
        }

        // Determines if a card is inferior to another
        public static bool operator <(Card left, Card right)
        {
            return (left.CardValue < right.CardValue);
        }

        // Determines if a card is equivalent or of greater value than another
        public static bool operator >=(Card left, Card right)
        {
            return (left.CardValue >= right.CardValue);
        }

        // Determines if a card is equivalent or of lesser value than another
        public static bool operator <=(Card left, Card right)
        {
            return (left.CardValue <= right.CardValue);
        }

        // Used for comparing cards
        public override int GetHashCode()
        {
            return this.myValue * 100 + (int)this.mySuit * 10 + ((this.faceUp)?1:0);
        }

        public Image GetCardImage()
        {
            string imageName;
            Image cardImage;

            if (!faceUp)
            {
                imageName = "gray_back";
            }
            else
            {
                imageName = myRank.ToString() + mySuit.ToString();
            }
            // Set the image to the appropriate object
            cardImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;
            return cardImage;
        }

        /// <summary>
        /// DebugString
        /// Generates a strign showing the state of the card object; useful for debugging
        /// </summary>
        /// <returns></returns>
        public string DebugString()
        {
            string cardState = (string)(myRank.ToString() + " of " + mySuit.ToString()).PadLeft(20);
            cardState += (string)((FaceUp) ? "(Face Up)" : "(Face Down)").PadLeft(12);
            cardState += " Value: " + myValue.ToString().PadLeft(2);
            cardState += ((altValue != null) ? "/" + altValue.ToString() : "");
            return cardState;
        }

        /// <summary>
        /// Overrides the base ToString() method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string cardString;

            if (faceUp)
            {
                cardString = myRank.ToString() + " of " + mySuit.ToString();
            }
            else
            {
                cardString = "Face Down";
            }
            return cardString;
        }

        /// <summary>
        /// CompareTo method
        /// Card-specific comparison method used to sort Card instances.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public virtual int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Unable to copare a Card to a null object.");
            }

            // Convert the default argument object to a card object
            Card compareCard = obj as Card;

            // Conversion worked
            if (compareCard != null)
            {
                // Compare based on the value, then the suit
                int thisSort = this.myValue * 10 + (int)this.mySuit;
                int compareCardSort = compareCard.myValue * 10 + (int)compareCard.mySuit;
                return (thisSort.CompareTo(compareCardSort));
            }
            else
            {
                throw new ArgumentException("Object being compared cannot be converted to a Card object.");
            }
        }
    }
}
