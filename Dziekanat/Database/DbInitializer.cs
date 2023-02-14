using System;
using System.Linq;
using Dziekanat.Models;
using System.Collections.Generic;

namespace Dziekanat.Database
{
    public static class DbInitializer
    {
        public static void Initialize(DziekanatContext context)
        {
            context.Database.EnsureCreated();
            if (context.User.Any())
            {
                return;   // DB has been seeded
            }

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
            var zajecia = new Zajecia[]{
                new Zajecia("a1","Angielski",6,"Ćwiczenia","Zaliczenie ocena",2),
                new Zajecia("w1","Bezpieczeństwo systemów",6,"Wykład","Ocena końcowa",4),
                new Zajecia("l1","Bezpieczeństwo systemów",7,"Laboratoria","Zaliczenie ocena",0),

                new Zajecia("w1","Wzorce projektowe",8,"Wykład","Ocena końcowa",4),
                new Zajecia("l1","Wzorce projektowe",9,"Laboratoria","Zaliczenie ocena",0),

                new Zajecia("w1","Programowanie ASP.NET",7,"Wykład","Ocena końcowa",4),
                new Zajecia("l1","Programowanie ASP.NET",7,"Laboratoria","Zaliczenie ocena",0),

                new Zajecia("w1","Zaawansowane bazy danych",8,"Wykład","Ocena końcowa",4),
                new Zajecia("l1","Zaawansowane bazy danych",6,"Laboratoria","Zaliczenie ocena",0),
            };

            var lecturer = new Lecturer[]{
                new Lecturer(DateTime.Now,"Doktor","Zarządzanie",6),
                new Lecturer(DateTime.Now,"Profesor","Informatyka",7),
                new Lecturer(DateTime.Now,"Magister","Zarządzanie",8),
                new Lecturer(DateTime.Now,"Doktor","Informatyka",9),
            };

            var students = new Student[]{
                new Student(2,"Programowanie","Studiujacy",2,4,13504,"Informatyka","informatyka stosowana","aplikacje","aplikacje","inzynier","2020/2021", DateTime.Now,DateTime.Now,false,"11333322222","Kraków",true,"Wolny","Polska","Polskie","ABC 123456","AA 23133","Maria","Adam","Uliczna 5","39-334","Kraków","email1@email.com","133333333","abc123","2019","2019","ZSE 2","Nowa","Stacjonarnie","w1","l1","a1"),
                new Student(3,"Gry","Studiujacy",1,2,13504,"Informatyka","informatyka stosowana","gry","gry","inzynier","2021/2022", DateTime.Now,DateTime.Now,false,"11333322222","Kraków",true,"Wolny","Polska","Polskie","ABC 123456","AA 23133","Monika","Andrzej","Uliczna 2","39-333","Kraków","email2@email.com","5612151256","abc123","2019","2019","ZSE 2","Nowa","Stacjonarnie","w1","l1","a1"),
                new Student(4,"Gry","Studiujacy",3,6,13504,"Informatyka","informatyka stosowana","gry","gry","inzynier","2019/2020", DateTime.Now,DateTime.Now,false,"11333322222","Kraków",true,"Wolny","Polska","Polskie","ABC 123456","AA 23133","Marta","Antony","Uliczna 4","39-332","Kraków","email3@email.com","55215","abc123","2019","2019","ZSE 2","Nowa","Stacjonarnie","w2","l2","a2"),
                new Student(5,"Programowanie","Studiujacy",2,4,13504,"Informatyka","informatyka stosowana","aplikacje","aplikacje","inzynier","2020/2021", DateTime.Now,DateTime.Now,false,"11333322222","Kraków",true,"Wolny","Polska","Polskie","ABC 123456","AA 23133","Magda","Adrian","Uliczna 15","39-331","Kraków","email4@email.com","5512125","abc123","2019","2019","ZSE 2","Nowa","Stacjonarnie","w3","l3","a3"),
            };

            var oceny = new Oceny[]{
                new Oceny(1,1,2,1),
                new Oceny(1,2,3.5,1),
                new Oceny(1,3,5,2),
                new Oceny(1,4,2.5,3),
                new Oceny(1,5,3,1),
                new Oceny(1,6,4,2),
                new Oceny(1,7,4.5,1),
                new Oceny(1,8,5,3),
                new Oceny(1,9,3,1),

                new Oceny(2,1,3,1),
                new Oceny(2,2,5,1),
                new Oceny(2,3,2.5,2),
                new Oceny(2,4,3.5,3),
                new Oceny(2,5,3,1),
                new Oceny(2,6,4.5,2),
                new Oceny(2,7,4,1),
                new Oceny(2,8,2,3),
                new Oceny(2,9,3,1),

                new Oceny(3,1,3,1),
                new Oceny(3,2,5,1),
                new Oceny(3,3,5,2),
                new Oceny(3,4,5,3),
                new Oceny(3,5,2.5,1),
                new Oceny(3,6,4,2),
                new Oceny(3,7,4.5,1),
                new Oceny(3,8,5,3),
                new Oceny(3,9,3,1),

                new Oceny(4,1,5,1),
                new Oceny(4,2,2,1),
                new Oceny(4,3,2,2),
                new Oceny(4,4,2,3),
                new Oceny(4,5,5,1),
                new Oceny(4,6,4.5,2),
                new Oceny(4,7,3,1),
                new Oceny(4,8,2,3),
                new Oceny(4,9,2.5,1),


            };


            context.AddRange(user);
            context.AddRange(zajecia);
            context.AddRange(lecturer);
            context.AddRange(oceny);
            context.AddRange(students);

            context.SaveChanges();
        }
    }
}
