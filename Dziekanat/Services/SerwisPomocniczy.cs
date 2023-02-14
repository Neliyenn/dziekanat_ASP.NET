using Dziekanat.Models;

namespace Dziekanat.Services
{
    public class SerwisPomocniczy
    {
        public bool LoginUser(string login, string password)
        {
            var user = new User[]{
                new User("admin","admin","admin","admin","admin"),
                new User("student1","student1","student1","student1","student"),
                new User("student2","student2","student2","student2","student"),
                new User("student3","student3","student3","student3","student"),
                new User("student4","student4","student4","student4","student"),
                new User("lecrurer1","lecrurer1","lecrurer1","lecrurer1","lecrurer"),
                new User("lecrurer2","lecrurer2","lecrurer2","lecrurer2","lecrurer"),
                new User("lecrurer3","lecrurer3","lecrurer3","lecrurer3","lecrurer"),
                new User("lecrurer4","lecrurer4","lecrurer4","lecrurer4","lecrurer"),
            };

            foreach (var item in user)
            {
                if (item.Login == login && item.Pass==password)
                {
                    return true;
                }
            }

            return false;
        }

        public bool PrzedmiotZaliczony(int studentID, int id_przedmiotu)
        {
            var oceny = new Oceny[]{
                new Oceny(1,5,3,1),
                new Oceny(2,2,3,1),
                new Oceny(3,4,5,1),
                new Oceny(4,3,2,1),
                new Oceny(5,1,4,1),

            };

            foreach (var item in oceny)
            {
                if (item.studentID == studentID && item.przedmiotID == id_przedmiotu)
                {
                    if (item.ocena > 2)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
