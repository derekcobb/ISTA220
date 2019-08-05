using System;

namespace Cards
{	
	class Pack
	{
        public const int NumSuits = 4;
        public const int CardsPerSuit = 13;
        private PlayingCard[,] cardPack;
        private Random randomCardSelector = new Random(); new instance of type random

        public Pack()
        {
            this.cardPack = new PlayingCard[NumSuits, CardsPerSuit];
            for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++) //enumeration variable
                for (Value value = Value.Two; value <= Value.Ace; value++)
                    this.cardPack[(int)suit, (int)value] = new PlayingCard(suit, value); //a new instance of PlayingCard is assigned to a multidimensional array
        }

        public PlayingCard DealCardFromPack() //Instance method
        {
            Suit suit = (Suit)randomCardSelector.Next(NumSuits); //
            while (this.IsSuitEmpty(suit))                          //this while loop selects a new suit when we run out of one type of loop
                suit = (Suit)randomCardSelector.Next(NumSuits);

            Value value = (Value)randomCardSelector.Next(CardsPerSuit); //symbolic instance "CardsPerSuit"
            while (this.IsCardAlreadyDealt(suit, value))
                value = (Value)randomCardSelector.Next(CardsPerSuit);

            PlayingCard card = this.cardPack[(int)suit, (int)value]; //This is one way we deal a card.
            this.cardPack[(int)suit, (int)value] = null;  //How you mark a card that has been dealt. Null is inserted into the cards spot.
            return card;
        }

        private bool IsSuitEmpty(Suit suit)
        {
            bool result = true;                     //Start off by assuming the suit is empty
            for (Value value = Value.Two; value <= Value.Ace; value++)
            {
                if (!IsCardAlreadyDealt(suit, value)) //If there is a card in the suit that means the suit is not empty and flips result to 'FALSE'
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private bool IsCardAlreadyDealt(Suit suit, Value value)
        {
            return (this.cardPack[(int)suit, (int)value] == null);
        }
    }
}