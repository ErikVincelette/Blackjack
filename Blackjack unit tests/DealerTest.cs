using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blackjack;
namespace Blackjack_unit_tests
{
    [TestClass]
    public class DealerTest
    {
        [TestMethod]
        public void dealer_logic_true()
        {
            /*
             * test different hands where dealer should take another hand
             * AAA10, AA10, 6A6, 2 3 5 4 
             * */
            dealer_logic_true1();
            dealer_logic_true2();
            dealer_logic_true3();
            dealer_logic_true4();
            
        }
         
        public void dealer_logic_true1()
        {
            //arrange
            Dealer d = new Dealer();
            d.add_card(1);
            d.add_card(1);
            d.add_card(1);
            d.add_card(10);

            bool expected = true;

            //act
            bool actual = d.logic();

            // assert
            Assert.AreEqual(expected, actual, "Wrong!");

        }
        public void dealer_logic_true2()
        {
            //arrange
            Dealer d = new Dealer();
            d.add_card(1);
            d.add_card(1);
            d.add_card(10);

            bool expected = true;

            //act
            bool actual = d.logic();

            // assert
            Assert.AreEqual(expected, actual, "Wrong!");

        }

        public void dealer_logic_true3()
        {
            //arrange
            Dealer d = new Dealer();
            d.add_card(6);
            d.add_card(1);
            d.add_card(6);

            bool expected = true;

            //act
            bool actual = d.logic();

            // assert
            Assert.AreEqual(expected, actual, "Wrong!");

        }

        public void dealer_logic_true4()
        {
            //arrange
            Dealer d = new Dealer();
            d.add_card(2);
            d.add_card(3);
            d.add_card(5);
            d.add_card(4);

            bool expected = true;

            //act
            bool actual = d.logic();

            // assert
            Assert.AreEqual(expected, actual, "Wrong!");

        }

        [TestMethod]
        public void dealer_logic_false()
        {
            /*
             * test different hands
             * A6, D2J, 5D6, D7, 2 3 8 2 2
             * */
            dealer_logic_false1();
            dealer_logic_false2();
            dealer_logic_false3();
            dealer_logic_false4();
            dealer_logic_false5();
            
            
        }

        public void dealer_logic_false1()
        {
            //arrange
            Dealer d = new Dealer();
            d.add_card(1);
            d.add_card(6);

            bool expected = false;

            //act
            bool actual = d.logic();

            // assert
            Assert.AreEqual(expected, actual, "Wrong!");

        }
        public void dealer_logic_false2()
        {
            //arrange
            Dealer d = new Dealer();
           
            d.add_card(10);
            d.add_card(2);
            d.add_card(10);

            bool expected = false;

            //act
            bool actual = d.logic();

            // assert
            Assert.AreEqual(expected, actual, "Wrong!");

        }
        public void dealer_logic_false3()
        {
            //arrange
            Dealer d = new Dealer();
            d.add_card(10);
            d.add_card(6);
            d.add_card(5);

            bool expected = false;

            //act
            bool actual = d.logic();

            // assert
            Assert.AreEqual(expected, actual, "Wrong!");

        }
        public void dealer_logic_false4()
        {
            //arrange
            Dealer d = new Dealer();
            d.add_card(10);
            d.add_card(7);

            bool expected = false;

            //act
            bool actual = d.logic();

            // assert
            Assert.AreEqual(expected, actual, "Wrong!");

        }
        public void dealer_logic_false5()
        {
            //arrange
            Dealer d = new Dealer();
            d.add_card(2);
            d.add_card(3);
            d.add_card(8);
            d.add_card(2);
            d.add_card(2);

            bool expected = false;

            //act
            bool actual = d.logic();

            // assert
            Assert.AreEqual(expected, actual, "Wrong!");

        }

        [TestMethod]
        public void dealer_blackjack()
        {
            dealer_blackjack1();
            dealer_blackjack2();
       
        }
        public void dealer_blackjack1()
        {
            //arrange
            Dealer d = new Dealer();
            d.add_card(1);
            d.add_card(10);


            bool expected = true;

            //act
            bool actual = d.dealer_blackjack();

            // assert
            Assert.AreEqual(expected, actual, "Wrong!");

        }
        public void dealer_blackjack2()
        {
            //arrange
            Dealer d = new Dealer();
            d.add_card(1);
            d.add_card(9);


            bool expected = false;

            //act
            bool actual = d.dealer_blackjack();

            // assert
            Assert.AreEqual(expected, actual, "Wrong!");

        }
    }
}
