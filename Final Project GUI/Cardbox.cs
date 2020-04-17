using CardLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyCardBox
{
    public class CardBox : UserControl
    {
        private Card myCard;
        private PictureBox pbThePictureBox;

        // Property for a card
        public Card Card
        {
            set
            {
                myCard = value;
                SetImage();
            }
            get
            {
                return myCard;
            }
        }

        // Property for a card's suit
        public Suit Suit
        {
            set
            {
                Card.Suit = value;
                SetImage();
            }
            get
            {
                return Card.Suit;
            }
        }

        // Property for a card's rank
        public Rank Rank
        {
            set
            {
                Card.Rank = value;
                SetImage();
            }
            get
            {
                return Card.Rank;
            }
        }

        // The card's face up property
        public bool FaceUp
        {
            set
            {
                myCard.FaceUp = value;
                SetImage();
            }
            get
            {
                return Card.FaceUp;
            }
        }

        // Changes the image of the picturebox to image of the card it's housing
        private void SetImage()
        {
            pbThePictureBox.Image = myCard.GetCardImage();
        }

        // Default constructor - we don't want to use this
        public CardBox()
        {
           
        }

        // Param constructor - creates a cardbox with a card in it
        public CardBox(Card card)
        {
            // Set the card value to the passed card's
            myCard = card;
            
            // Create the picture box and set it's attributes
            pbThePictureBox = new PictureBox();
            pbThePictureBox.Dock = DockStyle.Fill;
            pbThePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            AllowDrop = true;
            Controls.Add((Control)pbThePictureBox);
            Size = new Size(90, 151);

            // Wire the event handlers
            Load += new EventHandler(CardBox_Load);
            pbThePictureBox.Click += new EventHandler(pbThePictureBox_Click);
            //pbThePictureBox.MouseDown += new MouseEventHandler(pbThePictureBox_MouseDown);
            pbThePictureBox.MouseEnter += new EventHandler(pbThePictureBox_MouseEnter);
            pbThePictureBox.MouseLeave += new EventHandler(pbThePictureBox_MouseLeave);
        }

        // Sets the appropriate image on load
        private void CardBox_Load(object sender, EventArgs e)
        {
            SetImage();
        }

        public new event EventHandler Click;

        private void pbThePictureBox_Click(object sender, EventArgs e)
        {
            if (Click == null)
                return;
            Click(this, e);
        }

        public new event EventHandler MouseEnter;

        private void pbThePictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (MouseEnter == null)
                return;
            MouseEnter(this, e);
        }

        public new event EventHandler MouseLeave;

        private void pbThePictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (MouseLeave == null)
                return;
            MouseLeave(this, e);
        }

        public new event MouseEventHandler MouseDown;

        private void pbThePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseDown == null)
                return;
            MouseDown(this, e);
        }

        public override string ToString()
        {
            return myCard.ToString();
        }
    }
}
