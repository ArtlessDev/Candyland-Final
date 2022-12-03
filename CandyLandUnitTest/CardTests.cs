using Microsoft.VisualStudio.TestTools.UnitTesting;
using Candyland_Final;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyland_Final.Tests
{
    [TestClass()]
    public class CardTests
    {
        [TestMethod()]
        public void CardTest()
        {
            Card cardTest1 = new Card();
            Card cardTest2 = new Card();

            string cardImgDefault = "picture not set";
            string cardTypeDefault = "type not set";

            Assert.AreEqual(cardTypeDefault, cardTest1.CardType);
            Assert.AreEqual(cardImgDefault, cardTest1.CardImg);
            Assert.AreEqual(cardTypeDefault, cardTest2.CardType);
            Assert.AreEqual(cardImgDefault, cardTest2.CardImg);
        }
        [TestMethod()]
        public void PickCardTest()
        {
            Card cardTest1 = new Card();
            Card cardTest2 = new Card();
            Card cardTest3 = new Card();

            cardTest1.CardType = cardTest1.PickCard();
            cardTest2.CardType = cardTest2.PickCard();
            cardTest3.CardType = cardTest3.PickCard();
            //should all be different
            Assert.AreNotEqual(cardTest1, cardTest2);
            Assert.AreNotEqual(cardTest1, cardTest3);
            Assert.AreNotEqual(cardTest3, cardTest2);

        }
        [TestMethod()]
        public void CardImgTest()
        {
            string ci1 = "testString";
            string ci2 = "blue";
            string ci3 = "green";

            Card cardTest1 = new Card();
            Card cardTest2 = new Card();
            Card cardTest3 = new Card();

            cardTest1.CardImg = ci1;
            cardTest2.CardImg = ci2;
            cardTest3.CardImg = ci3;

            Assert.AreEqual(ci1, cardTest1.CardImg);
            Assert.AreEqual(ci2, cardTest2.CardImg);
            Assert.AreEqual(ci3, cardTest3.CardImg);

            cardTest2.CardImg = ci3;

            Assert.AreEqual(cardTest3.CardImg, cardTest2.CardImg);
        }
        [TestMethod()]
        public void CardTypeTest()
        {
            string ct1 = "testString";
            string ct2 = "color card";
            string ct3 = "special card";

            Card cardTest1 = new Card();
            Card cardTest2 = new Card();
            Card cardTest3 = new Card();

            cardTest1.CardType = ct1;
            cardTest2.CardType = ct2;
            cardTest3.CardType = ct3;

            Assert.AreEqual(ct1, cardTest1.CardType);
            Assert.AreEqual(ct2, cardTest2.CardType);
            Assert.AreEqual(ct3, cardTest3.CardType);

            cardTest2.CardType = ct3;

            Assert.AreEqual(cardTest3.CardType, cardTest2.CardType);
        }
    }
}