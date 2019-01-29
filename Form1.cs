using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckCards
{
    public partial class Form1 : Form
    {
        static List<Card> someCards = CreateCardDeck(10);
        List<Card> copySomeCards = new List<Card>(someCards);
        List<Card> allCards = AddAllCards();
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
            {
                comboCustomColour.Items.Add((Colour)i);
                comboComparedColour.Items.Add((Colour)i);

                string MyVariabel = ((Value)3).ToString();
            }
            for (int i = 1; i < 14; i++)
            {
                comboCustomValue.Items.Add((Value)i);
                comboComparedValue.Items.Add((Value)i);
            }

            foreach (var item in someCards)
            {
                lstCardDeckOne.Items.Add(item.Name);
            }

            foreach (var item in allCards)
            {
                lstCardDeckTwo.Items.Add(item.Name);
            }

        }   
        public static bool IsCard(Card card, Value value)
        {
            if (card.NumberValue == (int)value)
            {
                return true;
            }

            return false;
        }
        public static bool IsCard(Card card, Colour colour)
        {
            if (card.Colour == colour.ToString())
            {
                return true;
            }

            return false;
        }
        static private List<Card> AddAllCards()
        {
            List<Card> CardDeck = new List<Card>();

            for (int colour = 0; colour <= 3; colour++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    Card randomCard = new Card((Colour)colour, (Value)value);
                    CardDeck.Add(randomCard);
                }
            }

            return CardDeck;
        }
        static public List<Card> CreateCardDeck(int amountOfCards)
        {
            List<Card> CardDeck = new List<Card>();

            Random r = new Random();

            for (int i = 0; i < amountOfCards; i++)
            {
                int numberForColour = r.Next(4);
                int numberForValue = r.Next(1, 14);

                Card randomCard = new Card((Colour)numberForColour, (Value)numberForValue);
                CardDeck.Add(randomCard);
            }

            return CardDeck;
        }
        private void btnCompare_Click(object sender, EventArgs e)
        {
            string isSame = string.Empty;
            if (comboCustomColour.Text == comboComparedColour.Text)
            {
                isSame += "The Colour is the same\n";
            }

            if (comboCustomValue.Text == comboComparedValue.Text)
            {
                isSame += "The Value is the same\n";
            }

            if (isSame != string.Empty)
            {
                MessageBox.Show(isSame, "Similarities");
            }
            else
            {
                isSame = "There are no similarities";
                MessageBox.Show(isSame, "Similarities");
            }
        }
        private void toFirst_Click(object sender, EventArgs e)
        {
            if (!(lstCardDeckTwo.SelectedItem is null))
            {
                lstCardDeckOne.Items.Add(lstCardDeckTwo.SelectedItem);
                someCards.Add(allCards[lstCardDeckTwo.SelectedIndex]);

                allCards.RemoveAt(lstCardDeckTwo.SelectedIndex);
                lstCardDeckTwo.Items.Remove(lstCardDeckTwo.SelectedItem);
            }
        }
        private void toSecond_Click(object sender, EventArgs e)
        {
            if (!(lstCardDeckOne.SelectedItem is null))
            {
                lstCardDeckTwo.Items.Add(lstCardDeckOne.SelectedItem);
                allCards.Add(someCards[lstCardDeckOne.SelectedIndex]);

                someCards.RemoveAt(lstCardDeckOne.SelectedIndex);
                lstCardDeckOne.Items.Remove(lstCardDeckOne.SelectedItem);
            }
        }
        private List<Card> SortList(List<Card> toSort)
        {
            int currentItem = 0;
            List<Card> copyOfDeck = new List<Card>(toSort);
            CardComparer Comparer = new CardComparer();

            while (currentItem + 1 < toSort.Count)
            {
                int comparedItem = 0;

                foreach (var item in toSort)
                {
                    int Compared = Comparer.Compare(copyOfDeck[currentItem], item);

                    if (Compared == 1 && currentItem < comparedItem)
                    {
                        Card biggerCard = copyOfDeck[currentItem];
                        copyOfDeck[currentItem] = copyOfDeck[comparedItem];
                        copyOfDeck[comparedItem] = biggerCard;
                    }

                    comparedItem++;
                }

                currentItem++;
            }

            return copyOfDeck;
        }

        private void btnSortOne_Click(object sender, EventArgs e)
        {
            someCards = SortList(someCards);

            lstCardDeckOne.Items.Clear();

            foreach (var item in someCards)
            {
                lstCardDeckOne.Items.Add(item.Name);
            }
        }

        private void btnSortTwo_Click(object sender, EventArgs e)
        {
            allCards = SortList(allCards);

            lstCardDeckTwo.Items.Clear();

            foreach (var item in allCards)
            {
                lstCardDeckTwo.Items.Add(item.Name);
            }
        }

        private void btnResetOne_Click(object sender, EventArgs e)
        {
            lstCardDeckOne.Items.Clear();

            someCards = new List<Card>(copySomeCards);

            foreach (var item in someCards)
            {
                lstCardDeckOne.Items.Add(item.Name);
            }
        }

        private void btnResetTwo_Click(object sender, EventArgs e)
        {
            lstCardDeckTwo.Items.Clear();

            allCards = AddAllCards();

            foreach (var item in allCards)
            {
                lstCardDeckTwo.Items.Add(item.Name);
            }
        }
    }
}
