using System;

namespace DziekanatBlazor.Models
{
    public class Student
    {


        public int ID { get; set; }
        public int userID { get; set; }
        public string tok_studiow { get; set; }
        public string status { get; set; }
        public int rok { get; set; }
        public int semestr { get; set; }
        public string tryb { get; set; }
        public int nr_albumu { get; set; }
        public string wydzial { get; set; }
        public string kierunek { get; set; }
        public string specjalnosc { get; set; }
        public string specjalizacja { get; set; }
        public string uzyskiwany_tytul { get; set; }
        public string semestr_naboru { get; set; }
        public DateTime data_rozpoczecia { get; set; }
        public DateTime data_zakonczenia { get; set; }
        public bool tok_indywidualny { get; set; }
        public string pesel { get; set; }
        public string miejsce_urodzenia { get; set; }
        public bool plec { get; set; }
        public string stan_cywilny { get; set; }
        public string narodowosc { get; set; }
        public string obywatelstwo { get; set; }
        public string nr_dowodu { get; set; }
        public string nr_wojskowy { get; set; }
        public string imie_matki { get; set; }
        public string imie_ojca { get; set; }

        public string ulica { get; set; }
        public string kod_pocztowy { get; set; }
        public string miejscowosc { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }

        public string nr_matury { get; set; }
        public string rok_wydania { get; set; }
        public string rok_ukonczenia { get; set; }
        public string szkola { get; set; }
        public string rodzaj_matura { get; set; }


    }
}