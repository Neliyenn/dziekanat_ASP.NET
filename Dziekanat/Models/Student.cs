
using System;

namespace Dziekanat.Models
{
    public class Student
    {
        public int ID{get;set;}
        public int userID {get;set;}
        public string tok_studiow {get;set;}
        public string status {get;set;}
        public int rok {get;set;}
        public int semestr {get;set;}
        public string grupa_wyk{get;set;}
        public string grupa_lab{get;set;}
        public string grupa_ang{get;set;}
        public string tryb {get;set;}
        public int nr_albumu {get;set;}
        public string wydzial {get;set;}
        public string kierunek {get;set;}
        public string specjalnosc {get;set;}
        public string specjalizacja {get;set;}
        public string uzyskiwany_tytul {get;set;}
        public string semestr_naboru{get;set;}
        public DateTime data_rozpoczecia{get;set;}
        public DateTime data_zakonczenia{get;set;}
        public bool tok_indywidualny{get;set;}
        public string pesel {get;set;}
        public string miejsce_urodzenia{get;set;}
        public bool plec{get;set;}
        public string stan_cywilny{get;set;}
        public string narodowosc{get;set;}
        public string obywatelstwo{get;set;}
        public string nr_dowodu{get;set;}
        public string nr_wojskowy{get;set;}
        public string imie_matki{get;set;}
        public string imie_ojca{get;set;}

        public string ulica{get;set;}
        public string kod_pocztowy{get;set;}
        public string miejscowosc{get;set;}
        public string email{get;set;}
        public string telefon{get;set;}


        public string nr_matury{get;set;}
        public string rok_wydania{get;set;}
        public string rok_ukonczenia{get;set;}
        public string szkola{get;set;}
        public string rodzaj_matura{get;set;}

        public Student(int userID, string tok_studiow, string status, int rok, int semestr, int nr_albumu, string wydzial, string kierunek, string specjalnosc, string specjalizacja, string uzyskiwany_tytul, string semestr_naboru, DateTime data_rozpoczecia, DateTime data_zakonczenia, bool tok_indywidualny, string pesel, string miejsce_urodzenia, bool plec, string stan_cywilny, string narodowosc, string obywatelstwo, string nr_dowodu, string nr_wojskowy, string imie_matki, string imie_ojca, string ulica, string kod_pocztowy, string miejscowosc, string email,string telefon, string nr_matury, string rok_wydania, string rok_ukonczenia, string szkola, string rodzaj_matura,string tryb,string grupa_wyk,string grupa_lab,string grupa_ang)
        {
            this.userID = userID;
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
            this.pesel = pesel;
            this.miejsce_urodzenia = miejsce_urodzenia;
            this.plec = plec;
            this.stan_cywilny = stan_cywilny;
            this.narodowosc = narodowosc;
            this.obywatelstwo = obywatelstwo;
            this.nr_dowodu = nr_dowodu;
            this.nr_wojskowy = nr_wojskowy;
            this.imie_matki = imie_matki;
            this.imie_ojca = imie_ojca;
            this.ulica = ulica;
            this.kod_pocztowy = kod_pocztowy;
            this.miejscowosc = miejscowosc;
            this.email = email;
            this.telefon = telefon;
            this.nr_matury = nr_matury;
            this.rok_wydania = rok_wydania;
            this.rok_ukonczenia = rok_ukonczenia;
            this.szkola = szkola;
            this.rodzaj_matura = rodzaj_matura;
            this.tryb = tryb;
            this.grupa_wyk = grupa_wyk;
            this.grupa_lab = grupa_lab;
            this.grupa_ang = grupa_ang;
        }

        public Student()
        {
        }
    }
}