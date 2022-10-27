using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondTask
{
    internal class Client
    {
        public string Name;
        public string Surname;
        public string Email;
        public List<Card> Cards;
        public int Password;

        public Client (string name, string surname, string email, List<Card> cards, int password)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Cards = cards;
            Password = password;
        }
    }
}
