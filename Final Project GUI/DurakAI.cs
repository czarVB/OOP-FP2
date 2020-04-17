using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLib;

namespace Final_Project_GUI
{
    public class DurakAI
    {

        private Hand myHand = new Hand();

        public Card getCard(int index)
        {
            if (index < 0 || index >= myHand.Count)
            {
                throw new ArgumentOutOfRangeException("That card does not exist");
            }
            else
            {
                return myHand[index];
            }
        }

        public void AddCards(Deck deck, int amount)
        {
            myHand.AddCards(deck, amount);
        }



    }
}
