//11.Write a program that prints all possible cards from a standard deck 
//of 52 cards (without jokers). The cards should be printed with their
//English names. Use nested for loops and switch-case.
using System;

class AllCards
{
    static void Main()
    {
        Console.WriteLine("Prints all cards: ");
        string colors = "0";
        string cards = "0";
        for (int color = 1; color <= 4; color++)
        {
            for (int card = 2; card <= 14; card++)
            {
                switch (color)
                {
                    case 1:
                        colors = "Spades";
                        break;
                    case 2:
                        colors = "Diamonds";
                        break;
                    case 3:
                        colors = "Hearts";
                        break;
                    case 4:
                        colors = "Clubs";
                        break;
                }
                switch (card)
                {
                    case 11:
                        cards = "Ace";
                        break;
                    case 12:
                        cards = "Jack";
                        break;
                    case 13:
                        cards = "Queen";
                        break;
                    case 14:
                        cards = "King";
                        break;
                    default:
                        cards = card.ToString();
                        break;
                }
                Console.WriteLine(cards + " " + colors);
            }
        }
    }
}