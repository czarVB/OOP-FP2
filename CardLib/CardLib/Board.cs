using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Board.cs - A class determining the behaviour of the board
 *
 * Author: Hamza Khan - 100709587
 * Writen: 2020/04/10
 * Since: 2020/04/17
 */
namespace CardLib
{
    public class Board : List<Card>, ICloneable
    {
        Cards theBoard = new Cards();
        private int riverCardsRemaning = 0;


        //default constructor
        public Board()
        {

        }

        //parameriterized constructor sets new Board
        public Board(Cards newDeck)
        {
            theBoard = newDeck;
        }


        //addcardtoriver method, will add a card to Board
        public void AddCard(Card card)
        {
            theBoard.Add(card);
            riverCardsRemaning = theBoard.Count();
        }

        //removecardfromriver method, will remove a card from the Board
        public void RemoveCard(Card card)
        {
            theBoard.Remove(card);
            riverCardsRemaning = theBoard.Count();
        }

        //shows the length of the Board
        public int length()
        {
            return theBoard.Count();
        }

        //get card based on int number
        public Card GetCard(int cardNumber)
        {
            if (cardNumber >= 0 && cardNumber <= 51)
                return theBoard[cardNumber];
            else
                throw (new System.ArgumentOutOfRangeException("cardNumber", cardNumber, "The deck is between 0 and 51 cards long, how do you screw this up?."));
        }

        //clones the Board cards
        public object Clone()
        {
            Board newBoard = new Board(theBoard.Clone() as Cards);
            return newBoard;
        }

        //clears the Board
        public void Clear()
        {
            theBoard.Clear();
        }

        //will compare the cards enetered into Board
        public bool cardDefendValidation(Suit trumpSuit, Card card)
        {
            bool defended = false;

            if (theBoard.Count % 2 == 0)
            {
                if (card.Suit == theBoard[theBoard.Count - 1].Suit | theBoard[1].Suit == trumpSuit)
                {
                    if (card > theBoard[theBoard.Count - 1] | theBoard[theBoard.Count].Suit == trumpSuit)
                        defended = true;
                }
                return defended;
            }
            return defended;
        }

        //Attacking phase for human players
        public bool cardAttackValidation(Card attackingCard)
        {
            bool attack = false;

            if (theBoard.Count == 0)
            {
                attack = true;
            }

            if (theBoard.Count % 2 != 0)
            {
                if (attackingCard.Rank == theBoard[theBoard.Count].Rank | attackingCard.Rank == theBoard[theBoard.Count - 1].Rank)
                {
                    attack = true;
                }
            }
            return attack;
        }

        //shuffle method, randomizes the order of the cards, 
        //then uses the copy to method in cardlist to copy over the cards to a new deck. 
        public void Shuffle(int deckSize)
        {
            Cards newDeck = new Cards();
            bool[] assigned = new bool[deckSize];
            Random sourceGen = new Random();
            for (int i = 0; i < deckSize; i++)
            {
                int sourceCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    sourceCard = sourceGen.Next(deckSize);
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }
                assigned[sourceCard] = true;
                newDeck.Add(theBoard[sourceCard]);
            }
            newDeck.CopyTo(theBoard);
        }
    }
}