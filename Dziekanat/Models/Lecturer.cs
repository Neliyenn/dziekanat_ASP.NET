using System;

namespace Dziekanat.Models
{
    public class Lecturer
    {
        public int ID{get;set;}
        public int userID {get;set;}
        public DateTime employe_data {get;set;}
        public string position {get;set;}

        public string department {get;set;}

        public Lecturer(DateTime employe_data, string position, string department,int userID)
        {
            this.userID = userID;
            this.employe_data = employe_data;
            this.position = position;
            this.department = department;
        }
    }
}