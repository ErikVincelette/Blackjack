using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blackjack;
using System.Collections.Generic;
namespace Blackjack_unit_tests
{
   
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void calculate_win()
        {
            // p_win, d_win, d_bust, p_bust, d and p bust, push
            calculate_win1();
            calculate_win2();
            calculate_win3();
            calculate_win4(); 
            calculate_win5();
            calculate_win6(); 

        }

        public void calculate_win1()
        {
            //
            Card c1 = new Card(8, "C8");
            Card c2 = new Card(10, "DH");

            Player p = new Player();
            p.add_card(c1);
            p.add_card(c2);
            short starting_bet = 10;
            short final_bet = 20;
            p.Player_Bet = starting_bet;
            p.bets[0] = 10;

            Dealer d = new Dealer();
            d.Hand_Value = 17;           

            //act            
            p.calculate_win(d.Hand_Value);
            short actual = p.Player_Bet;

            //Assert
            Assert.AreEqual(final_bet, actual, "Player wins!");

        }

        public void calculate_win2()
        {
            //
            Card c1 = new Card(7, "C7");
            Card c2 = new Card(10, "DH");

            Player p = new Player();
            p.add_card(c1);
            p.add_card(c2);
            short starting_bet = 10;
            short final_bet = 0;
            p.Player_Bet = starting_bet;
            p.bets[0] = 10;

            Dealer d = new Dealer();
            d.Hand_Value = 18;

            //act            
            p.calculate_win(d.Hand_Value);
            short actual = p.Player_Bet;

            //Assert
            Assert.AreEqual(final_bet, actual, "Dealer wins!");

        }

        public void calculate_win3()
        {
            //
            Card c1 = new Card(7, "C7");
            Card c2 = new Card(10, "DH");

            Player p = new Player();
            p.add_card(c1);
            p.add_card(c2);
            short starting_bet = 10;
            short final_bet = 20;
            p.Player_Bet = starting_bet;
            p.bets[0] = 10;

            Dealer d = new Dealer();
            d.Hand_Value = 22;

            //act            
            p.calculate_win(d.Hand_Value);
            short actual = p.Player_Bet;

            //Assert
            Assert.AreEqual(final_bet, actual, "Dealer bust!");

        }

        public void calculate_win4()
        {
            //
            Card c1 = new Card(7, "/C");
            Card c2 = new Card(10, "DH");
            Card c3 = new Card(6, "6D");

            Player p = new Player();
            p.add_card(c1);
            p.add_card(c2);
            p.add_card(c3);
            short starting_bet = 10;
            short final_bet = 0;
            p.Player_Bet = starting_bet;
            p.bets[0] = 10;

            Dealer d = new Dealer();
            d.Hand_Value = 17;

            //act            
            p.calculate_win(d.Hand_Value);
            short actual = p.Player_Bet;

            //Assert
            Assert.AreEqual(final_bet, actual, "Player bust!");

        }

        public void calculate_win5()
        {
            //
            Card c1 = new Card(7, "/C");
            Card c2 = new Card(10, "DH");
            Card c3 = new Card(6, "6D");

            Player p = new Player();
            p.add_card(c1);
            p.add_card(c2);
            p.add_card(c3);
            short starting_bet = 10;
            short final_bet = 0;
            p.Player_Bet = starting_bet;
            p.bets[0] = starting_bet;

            Dealer d = new Dealer();
            d.Hand_Value = 22;

            //act            
            p.calculate_win(d.Hand_Value);
            short actual = p.Player_Bet;

            //Assert
            Assert.AreEqual(final_bet, actual, "Dealer and player bust!");

        }

        public void calculate_win6()
        {
            //
            Card c1 = new Card(7, "/C");
            Card c2 = new Card(10, "DH");

            Player p = new Player();
            p.add_card(c1);
            p.add_card(c2);
            short starting_bet = 10;
            short final_bet = 10;
            p.Player_Bet = starting_bet;
            p.bets[0] = starting_bet;

            Dealer d = new Dealer();
            d.Hand_Value = 17;

            //act            
            p.calculate_win(d.Hand_Value);
            short actual = p.Player_Bet;

            //Assert
            Assert.AreEqual(final_bet, actual, "Dealer bust!");

        }

        [TestMethod]
        public void blackjack_win()
        {
            short starting_bet = 10;
            short final_bet = 20;
            Player p = new Player();
            p.Player_Bet = starting_bet;
            p.blackjack_win();

            short actual = p.Player_Bet;
            Assert.AreEqual(final_bet, actual, "Blackjack Win!");

        }

        [TestMethod]
        public void blackjack_loss()
        {        
            short starting_bet = 10;
            short final_bet = 0;
            Player p = new Player();
            p.bets[0] = starting_bet;
            p.Player_Bet = starting_bet;
            p.loss();

            short actual = p.Player_Bet;
            Assert.AreEqual(final_bet, actual, "Blackjack loss!");

        }
        
        [TestMethod]
        public void hit_logic()
        {
            //player bust, player 21, player under 21
            hit_logic1();
           // hit_logic2();
            hit_logic3();

        }
        public void hit_logic1()
        {
            Card c1 = new Card(7, "7C");
            Card c2 = new Card(10, "DH");
            Card c3 = new Card(7, "7C");
            Player p = new Player();
            p.add_card(c1);
            p.add_card(c2);
            p.add_card(c3);
            bool expected = false;

            bool actual = p.hit_logic();

            Assert.AreEqual(expected, actual, "Player does not bust on 24!");

        }

        public void hit_logic2()
        {
            Card c1 = new Card(7, "7C");
            Card c2 = new Card(10, "DH");
            Card c3 = new Card(4, "4C");
            Player p = new Player();
            p.add_card(c1);
            p.add_card(c2);
            p.add_card(c3);
            bool expected = false;

            bool actual = p.hit_logic();

            Assert.AreEqual(expected, actual, "Player stops on 21");

        }

        public void hit_logic3()
        {
            Card c1 = new Card(7, "7C");
            Card c2 = new Card(10, "DH");
            Card c3 = new Card(2, "2C");
            Player p = new Player();
            p.add_card(c1);
            p.add_card(c2);
            p.add_card(c3);
            bool expected = true;

            bool actual = p.hit_logic();

            Assert.AreEqual(expected, actual, "Player does not bust on 19");

        }

        [TestMethod]
        public void double_down_logic()
        {
            //player bust with another hand, player 21 with another hand
            double_down_logic1();
            double_down_logic2();

        }

        public void double_down_logic1()
        {
            Card c1 = new Card(7, "7C");
            Card c2 = new Card(10, "DH");
            Card c3 = new Card(7, "7C");
            Player p = new Player();
            string expected_status = "Bust";
            p.add_card(c1);
            p.add_card(c2);
            p.add_card(c3);
            p.nr_of_hands++;

            p.hand[1] = new List<Card>();
            p.hand[1].Add(c1);
            p.hand[1].Add(c2);
            bool expected = true;

            bool actual = p.double_down_logic();
            string actual_status = p.Hand_Status;
            Assert.AreEqual(expected_status, actual_status, "Player status is not Bust");
            Assert.AreEqual(expected, actual, "Player should have another hand");

        }

        public void double_down_logic2()
        {
            Card c1 = new Card(7, "7C");
            Card c2 = new Card(10, "DH");
            Card c3 = new Card(4, "4C");
            Player p = new Player();
            string expected_status = "21";
            p.add_card(c1);
            p.add_card(c2);
            p.add_card(c3);
            p.nr_of_hands++;

            p.hand[1] = new List<Card>();
            p.hand[1].Add(c1);
            p.hand[1].Add(c2);
            bool expected = true;

            bool actual = p.double_down_logic();
            string actual_status = p.Hand_Status;

            Assert.AreEqual(expected_status, actual_status, "Player should have 21");
            Assert.AreEqual(expected, actual, "Player should have another hand");

        }

        [TestMethod]
        public void split_logic()
        {
            //player bust with another hand, player 21 with another hand
            split_logic1();
            split_logic2();

        }
        public void split_logic1()
        {
            Card c1 = new Card(7, "7C");
            Card c2 = new Card(7, "DH");            
            Player p = new Player();            
            p.add_card(c1);
            p.add_card(c2);
            p.Player_Money = 20;
            p.bets[0] = 10;
            p.Player_Bet = 10;
            short expected_money = 10;
            short expected_total = 20;
            bool expected = true;

            //Act
            bool actual = p.split_logic();
            short actual_money = p.Player_Money;
            short actual_bet = p.bets[1];
            short actual_total = p.Player_Bet;

            Assert.AreEqual(expected_money, actual_bet, "Player bet should be 10");
            Assert.AreEqual(expected_money, actual_money, "Player money should be 10");
            Assert.AreEqual(expected_total, actual_total, "Total player bet should be 20");
            Assert.AreEqual(expected, actual, "Player should have another hand");
        }
        public void split_logic2()
        {
            Card c1 = new Card(7, "7C");
            Card c2 = new Card(7, "DH");
            Player p = new Player();
            p.add_card(c1);
            p.add_card(c2);
            p.Player_Money = 0;
            p.bets[0] = 10;
            p.Player_Bet = 10;
            short expected_money = 0;
            short expected_total = 10;
            bool expected = false;

            //Act
            bool actual = p.split_logic();
            short actual_money = p.Player_Money;            
            short actual_total = p.Player_Bet;

            Assert.AreEqual(expected_money, actual_money, "Player money should be 10");
            Assert.AreEqual(expected_total, actual_total, "Total player bet should be 10");
            Assert.AreEqual(expected, actual, "Player should not have another hand");

        }
    }
}
