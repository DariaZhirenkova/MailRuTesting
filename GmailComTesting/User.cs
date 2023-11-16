namespace MailRuTesting
{
    public class User//??
    {
        // private string _login;
        public string login { get; set; }


        //private string _password;
        public string password { get; set; }



        // private string _endOfEmail;
        public string endOfEmail { get; set; } 


        //private string _name;
        public string name { get; set; }


        //private string _fullEmail;
        public string fullEmail { get; set; }

        public User(string fullEmail, string login, string password, string endOfEmail, string name)
        {
            this.login = login;
            this.password = password;
            this.endOfEmail = endOfEmail;
            this.name = name;
            this.fullEmail = fullEmail;
        }
    }

      
    
}
