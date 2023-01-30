using System;
using System.Collections.Generic;

namespace Dziekanat.Models
{
    public class Student
    {
        public int ID { get; set; }
        public User user { get; set; }
        public string tok_studiow { get; set; }
        public string status { get; set; }
        public int rok { get; set; }
        public int semestr { get; set; }
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

        public Student(string tok_studiow, string status, int rok, int semestr, int nr_albumu, string wydzial, string kierunek, string specjalnosc, string specjalizacja, string uzyskiwany_tytul, string semestr_naboru, DateTime data_rozpoczecia, DateTime data_zakonczenia, bool tok_indywidualny)
        {
            this.tok_studiow = tok_studiow;
            this.status = status;
            this.rok = rok;
            this.semestr = semestr;
            this.nr_albumu = nr_albumu;
            this.wydzial = wydzial;
            this.kierunek = kierunek;
            this.specjalnosc = specjalnosc;
            this.specjalizacja = specjalizacja;
            this.uzyskiwany_tytul = uzyskiwany_tytul;
            this.semestr_naboru = semestr_naboru;
            this.data_rozpoczecia = data_rozpoczecia;
            this.data_zakonczenia = data_zakonczenia;
            this.tok_indywidualny = tok_indywidualny;
        }
    }
}
