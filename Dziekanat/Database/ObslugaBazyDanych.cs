using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dziekanat.Models;

namespace Dziekanat.Database
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

        public Student SetStudent(int userID)
        {
            Student student = new Student();
            student.userID = userID;
            foreach (var item in BazaDanychDziekanatu.Student.ToList())
            {
                if (item.userID == userID)
                {
                    student = item;
                    return student;
                }
            }
            BazaDanychDziekanatu.Student.Add(student);
            BazaDanychDziekanatu.SaveChanges();
            return student;
        }

        public Admin SetAdmin(int userID)
        {
            Admin admin = new Admin();
            admin.userID = userID;
            admin.level = 5;
            foreach (var item in BazaDanychDziekanatu.Admin.ToList())
            {
                if (item.userID == userID)
                {
                    admin = item;
                    return admin;
                }
            }
            BazaDanychDziekanatu.Admin.Add(admin);
            BazaDanychDziekanatu.SaveChanges();
            return admin;
        }

        public List<Zajecia> GetZajecia(int studentID)
        {
            Student student = new Student();
            student.userID = studentID;
            List<Zajecia> Zajecia = new List<Zajecia>();
            foreach (var item in BazaDanychDziekanatu.Student.ToList())
            {
                if (item.userID == studentID)
                {
                    student = item;
                }
            }

            foreach (var item in BazaDanychDziekanatu.Zajecia.ToList())
            {
                if (student.grupa_ang == item.grupa || student.grupa_lab == item.grupa || student.grupa_wyk == item.grupa)
                {
                    foreach (var item2 in BazaDanychDziekanatu.Oceny.ToList())
                    {
                        if (student.ID == item2.studentID && item.ID == item2.przedmiotID)
                        {
                            item.ocena = item2.ocena;
                            item.termin = item2.termin_zaliczenia;
                            foreach (var item3 in BazaDanychDziekanatu.User.ToList())
                            {
                                if (item.prowadzacyID == item3.ID)
                                {
                                    item.prowadzacy = item3.FirstName + " " + item3.LastName;
                                }
                            }
                        }
                    }
                    Zajecia.Add(item);
                }
            }


            return Zajecia;
        }

        public async Task<bool> ZmianaHasla(int userID, string password, string newpassword)
        {
            User user = new User();
            foreach (var item in BazaDanychDziekanatu.User.ToList())
            {
                if (item.ID == userID && item.Pass == password)
                {
                    user = item;
                    user.Pass = newpassword;
                    BazaDanychDziekanatu.User.Update(user);
                    await BazaDanychDziekanatu.SaveChangesAsync();
                    return true;
                }
            }
            return false;
        }

    }
}