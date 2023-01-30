using System.Collections.Generic;
using Dziekanat.Models;

namespace Dziekanat.Interfaces
{
    public interface IObslugaBazyDanych
    {
        User LoginUser(string login, string password);
        Student SetStudent(User user);
    }
}