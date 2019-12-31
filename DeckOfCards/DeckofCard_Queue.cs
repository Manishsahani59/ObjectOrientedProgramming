using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ObjectOrientedProgramming.DeckOfCards
{
    class DeckofCard_Queue
    {
        public void DeckOfCardqueue()
        {
            try { 
            int k = 0, index, counter = 0;
            string temp;
            int sum = 0;
            string[] Deckcards = new string[52];
            Queue Player = new Queue();
            Queue Player1 = new Queue();
            Queue Player2 = new Queue();
            Queue Player3 = new Queue();
            Queue Player4 = new Queue();
            Queue playingCards = new Queue();
            Player.Enequeue("player1");
            Player.Enequeue("player2");
            Player.Enequeue("player3");
            Player.Enequeue("player4");
            string[] suits = { "C", "D", "H", "S" };
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < cards.Length; j++)
                {

                    Deckcards[k] = suits[i] + cards[j];
                    k++;
                }
            }
            Random randomizeCard = new Random();
            for (int i = 0; i < Deckcards.Length; i++)
            {
                index = randomizeCard.Next(52 - i);
                temp = Deckcards[index];
                Deckcards[index] = Deckcards[i];
                Deckcards[i] = temp;
            }
            for (int i = 0; i < Deckcards.Length; i++)
            {
                playingCards.Enequeue(Deckcards[i]);

            }
            while (!playingCards.isEmpty())
            {
                while (counter <= 9)
                {
                    string data = playingCards.Dequeue();
                    Player1.Enequeue(data);
                    if (counter == 8)
                    {
                        Player1.Display();
                        string player = Player.Dequeue();
                        Console.Write(player);
                        Console.WriteLine();
                        Player1.sort();
                        Player1.Display();
                        Console.Write(player);
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    counter++;
                }
                while (counter >= 9 && counter <= 19)
                {
                    string data = playingCards.Dequeue();
                    Player2.Enequeue(data);
                    counter++;
                    if (counter == 19)
                    {
                        Player2.Display();
                        string player = Player.Dequeue();
                        Console.Write(player);
                        Console.WriteLine();
                        Player2.sort();
                        Player2.Display();
                        Console.Write(player);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
                while (counter >= 19 && counter <= 28)
                {
                    string data = playingCards.Dequeue();
                    Player3.Enequeue(data);
                    if (counter == 28)
                    {
                        Player3.Display();
                        string player = Player.Dequeue();
                        Console.Write(player);
                        Console.WriteLine();
                        Player3.sort();
                        Player3.Display();
                        Console.Write(player);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    counter++;
                }
                while (counter >= 28 && counter <= 37)
                {
                    string data = playingCards.Dequeue();
                    Player4.Enequeue(data);
                    if (counter == 37)
                    {
                        Player4.Display();
                        string player = Player.Dequeue();
                        Console.Write(player);
                        Console.WriteLine();
                        Player4.sort();
                        Player4.Display();
                        Console.Write(player);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    counter++;
                }
                string data1 = playingCards.Dequeue();
            }
        } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
}
    }
}
