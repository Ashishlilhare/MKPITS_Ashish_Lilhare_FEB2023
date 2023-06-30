namespace pro6.Models
{
    public class SignUp
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public bool subject1 { get; set; }
        public bool subject2 { get; set; }

        public city getcity { get; set; }

    }
    public enum city
    {
        Nagpur, Mumbai, Banglore,Hyderabad ,Delhi 
    }
}
