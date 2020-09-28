using System.Collections.Generic;
using System.Linq;

namespace BlackJackGame.Models
{
    public class Hand
    {

        #region Fields
        private readonly IList<BlackJackCard> _cards;
        #endregion

        #region Properties
        public IEnumerable<BlackJackCard> Cards { get; }

        public int NrOfCards { get; }

        public int Value { get; }
        #endregion

        #region Constructors
        public Hand()
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Methods
        public void AddCard(BlackJackCard blackJackCard)
        {
            throw new System.NotImplementedException();
        }

        public void TurnAllCardsFaceUp()
        {
            throw new System.NotImplementedException();
        }
        private int CalculateValue()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}