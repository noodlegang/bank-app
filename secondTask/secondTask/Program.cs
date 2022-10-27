using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondTask
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            List<Client> clientCol = new List<Client>();
            List<Card> cardsCol = new List<Card>();
            Console.WriteLine("Greetings! Are u a user or operator?");
            var ans = Console.ReadLine();
            var startAgain = true;
            do
            {
                if (ans.Trim().ToLower().Equals("user"))
                {
                    startUserMenu(clientCol, cardsCol);
                    Console.WriteLine("Again? y/n");
                    var res = Console.ReadLine();
                    if (res.Equals("n"))
                    {
                        startAgain = false;
                    }
                }
                else if (ans.Trim().ToLower().Equals("operator"))
                {
                    startOperatorMenu(clientCol, cardsCol);
                    Console.WriteLine("Again? y/n");
                    var res = Console.ReadLine();
                    if (res.Equals("n"))
                    {
                        startAgain = false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid answer");
                    Console.WriteLine("Again? y/n");
                    var res = Console.ReadLine();
                    if (res.Equals("n"))
                    {
                        startAgain = false;
                    }
                }
                
            } while (startAgain);
            Console.ReadKey();
        }

        private static void startOperatorMenu(List<Client> clients, List<Card> cards)
        {
            var passcode = "slay";
            Console.WriteLine("Please, type in operator passcode");
            var p = Console.ReadLine();
            if (p.Equals(passcode))
            {
                Console.WriteLine("Welcome, Operator!");
                Console.WriteLine("1. Add new user");
                Console.WriteLine("2. Add new card");
                Console.WriteLine("3. Add money to card");
                var a = Console.ReadLine();
                int b = int.Parse(a);
                switch (b)
                {
                    case 1:
                        
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        
                        break;
                }
            }
        }

        private static void startUserMenu(List<Client> clients, List<Card> cards)
        {
            Console.WriteLine("Please, login. Type in your email");
            var email = Console.ReadLine();
            Console.WriteLine("Type in your password");
            var password = Console.ReadLine();
            if (clients.Count==0)
            {
                Console.WriteLine("Non existent");
            } else
            {
                foreach (var item in clients)
                {
                    if ((item.Email.Equals(email))&&(item.Password.Equals(password)))
                    {
                        Console.WriteLine("Welcome, {0}!" + item.Name);
                        
                        if (cards.Count==0)
                        {
                            Console.WriteLine("Non existent");
                        } else
                        {
                            Console.WriteLine("Which card are you willing to use?");
                            var cardNum = Console.ReadLine();
                            Console.WriteLine("Enter PIN");
                            var pin = Console.ReadLine();
                            foreach (var card in cards)
                            {
                                if ((card.Number.Equals(cardNum)) && (card.PIN.Equals(pin)))
                                {
                                    Console.WriteLine("Select action");
                                    Console.WriteLine("1. Take money from card");
                                    Console.WriteLine("2. Check balance on card");
                                    Console.WriteLine("3. Change card PIN");
                                    var a = Console.ReadLine();
                                    int b = int.Parse(a);
                                    switch (b)
                                    {
                                        case 1:
                                            withdrawMoney(card);
                                            break;
                                        case 2:
                                            checkBalance(card);
                                            break;
                                        case 3:
                                            changePIN(card);
                                            break;
                                    }
                                }
                            }
                            
                        }
                                           }
                }
            }
           
        }

        private static void changePIN(Card card)
        {
            Console.WriteLine("Insert new PIN");
            var p = Console.ReadLine();
            int pin = Int32.Parse(p);
            card.PIN = pin;
        }

        private static void checkBalance(Card card)
        {
            Console.WriteLine(card.Money + "$");
        }

        private static void withdrawMoney(Card card)
        {
            Console.WriteLine("How much money do you want?");
            var p = Console.ReadLine();
            int money = Int32.Parse(p);
            if (card.Money>=money)
            {
                Console.WriteLine("Great success");
                card.Money = card.Money - money;
                Console.WriteLine("New balance: " + card.Money);
            }
        }
    }
}
