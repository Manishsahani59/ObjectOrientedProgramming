using System;
using System.Collections.Generic;
using System.Text;


namespace ObjectOrientedProgramming
{
    class DeckOfCard
    {
        public void DeckOfcard()
        {
            Random makeRandom = new Random();
           

            int k=0, NextLine = 8;
            string temp;
            string[] Deckcards = new string[52];
           //string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades"};
            string[] suits = { "C", "D", "H", "S"};
            string[] playerName = { "Manish", "Rahul", "Dinesh", "Shyam", "Nitn", "Hemant","Vishal","Vaibhav","Ranjeet","Neeraj" };
            string[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j =0; j < cards.Length; j++)
                {

                    Deckcards[k] = suits[i] + cards[j];
                    k++;
                }
            }
          
            for (int i = 0; i < 36; i++)
            {
                
              
                   int suffle = (int)(makeRandom.Next(52-i));
                   temp = Deckcards[suffle];
                   Deckcards[suffle] = Deckcards[i];
                   Deckcards[i] = temp;
                
            }
            Console.WriteLine("The Divide Crads With Four Player is ");
            Console.WriteLine();
            for (int i = 0; i < Deckcards.Length; i++)
            {
                
                Console.Write(Deckcards[i] +"\t");
                if (i == 36)
                    break;
                if (i == NextLine || NextLine == 52)
                {
                    int suffle = (int)(makeRandom.Next(0,10));
                    Console.Write("\t"+playerName[suffle]);
                         Console.WriteLine();
                         Console.WriteLine();
                    NextLine = NextLine + 9;
                    k++;
                    
                    
                }
            }

            for (int i = 0; i < Deckcards.Length; i++)
            {
                for (int j = 0; j < Deckcards.Length; j++)
                {
                    if (Deckcards[i].CompareTo(Deckcards[j])<0)
                    {
                        temp = Deckcards[i];
                        Deckcards[i] = Deckcards[j];
                        Deckcards[j] = temp;
                    }
                }
            }
         

        }

    }
}
