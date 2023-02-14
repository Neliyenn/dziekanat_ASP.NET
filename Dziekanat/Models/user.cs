namespace Dziekanat.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Login {get;set;}
        public string Pass{get;set;}
        public string Type{get;set;}

        public User(string FirstName,string LastName,string Login, string Pass,string Type) {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Login = Login;
            this.Pass = Pass;
            this.Type = Type;
        }

        public User()
        {
        }
    }
}