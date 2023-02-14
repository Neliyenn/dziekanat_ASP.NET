using System.Collections.Generic;
using System.Threading.Tasks;
using Dziekanat.Models;

namespace Dziekanat.Database
{
    public interface IObslugaBazyDanych
    {
        User LoginUser(string login, string password);
        Student SetStudent(int userID);
        Admin SetAdmin(int userID);
        List<Zajecia> GetZajecia(int studentID);

        Task<bool> ZmianaHasla(int userID, string password, string newpassword);
    }
}