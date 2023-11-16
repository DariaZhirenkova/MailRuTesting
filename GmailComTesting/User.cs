namespace MailRuTesting
{
    public class User//??
    {
        public string login { get; set; }

        public string password { get; set; }

        public string endOfEmail { get; set; } 

        public string name { get; set; }

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
