namespace Dziekanat.Models
{
    public class Oceny
    {
        public int ID{get;set;}
        public int studentID{get;set;}
        public int przedmiotID{get;set;}
        public double ocena{get;set;}
        public int termin_zaliczenia{get;set;}

        public Oceny(int studentID, int przedmiotID, double ocena,int termin_zaliczenia)
        {
            this.studentID = studentID;
            this.przedmiotID = przedmiotID;
            this.ocena = ocena;
            this.termin_zaliczenia = termin_zaliczenia;
        }
    }
}