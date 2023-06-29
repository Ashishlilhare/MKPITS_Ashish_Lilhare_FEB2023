namespace pro7.Models
{
    public class signup
    {
        public string username { get; set; }
        public string password { get; set; }
        public string gender { get; set; }
        public bool subject1 { get; set; }
        public bool subject2 { get; set; }
        public city getcity { get; set; }

    }
    public enum city
    {
        nagpur,mumbai,pune,mangloore,keral,hyderabad
    }
}
