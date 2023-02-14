
using System;

namespace Dziekanat.Models
{
    public class Zajecia
    {
        public int ID{get;set;}
        public string grupa {get;set;}
        public string nazwa{get;set;}
        public int prowadzacyID{get;set;}
        public string prowadzacy{get;set;}
        public string forma{get;set;}
        public string zaliczenie{get;set;}
        public int ects{get;set;}
        public double ocena{get;set;}
        public int termin{get;set;}
        public Zajecia(string grupa, string nazwa, int prowadzacyID, string forma, string zaliczenie, int ects)
        {
            this.grupa = grupa;
            this.nazwa = nazwa;
            this.prowadzacyID = prowadzacyID;
            this.forma = forma;
            this.zaliczenie = zaliczenie;
            this.ects = ects;
        }
    }
}