namespace WebApplication1.Models
{
    public class person
    {
        public string name;
        public int age;
        public int mobile_no;
        public string city;
        public string country;

        //contructor
        public person(string a, int b,int c,string d,string e)
        {
            name = a;
            age = b;
            mobile_no = c;
            city = d;
            country = e;


        }
        //creating property name for name, age ,mobileno,city,country
        public string Name
        {
            get
            {
                return name;

            }
        }
        public int Age
        {
            get
            {
                return age;

            }
        }
        public int Mobile_no
        {
            get
            {
                return mobile_no;

            }
        }
        public string City
        {
            get
            {
                return city;

            }
        }
        public string Country
        {
            get
            {
                return country;

            }
        }

    }
}
