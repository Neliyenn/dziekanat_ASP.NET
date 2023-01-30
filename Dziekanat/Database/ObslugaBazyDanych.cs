using System.Collections.Generic;
using System.Linq;
using Dziekanat.Interfaces;
using Dziekanat.Models;

namespace Dziekanat.Data
{
    public class ObslugaBazyDanych : IObslugaBazyDanych
    {
        private readonly DziekanatContext BazaDanychDziekanatu;
        public ObslugaBazyDanych(DziekanatContext BazaDanychDziekanatu)
        {
            this.BazaDanychDziekanatu = BazaDanychDziekanatu;
        }

        public User LoginUser(string login, string password)
        {

            foreach (var item in BazaDanychDziekanatu.User.ToList())
            {
                if (login == item.Login && password == item.Pass)
                {
                    User user = item;
                    return user;
                }
            }

            return null;
        }

        public Student SetStudent(User user)
        {

            return null;
        }

    }
}