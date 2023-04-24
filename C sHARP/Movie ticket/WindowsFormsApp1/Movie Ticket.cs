using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Movie_Ticket
    {
        public string Movie_Name { get; set; }
        public string Theater_Name { get; set; }
        public string Show_Time { get; set; }
        public float No_of_Seat { get; set; }
        public float Ticket_Price { get; set; }

        public abstract string Calculate_Ticket_Price();

    }

    class Online_Booking : Movie_Ticket
    {
       public Online_Booking(string Movie_Name, string Theater_Name, string Show_Time, float No_of_Seat, float Ticket_Price)
        {
            this.Movie_Name = Movie_Name;
            this.Theater_Name= Theater_Name;
            this.Show_Time = Show_Time;
            this.No_of_Seat = No_of_Seat;
            this.Ticket_Price = Ticket_Price;

        }
        public float discount { get; set; }
        public override string Calculate_Ticket_Price()
        {
            float tp = No_of_Seat * Ticket_Price ;
            discount = tp*0.20f;
            tp = tp - discount;
            return "Total Price =" + tp.ToString();
        }
    }
    class BoxOffice : Movie_Ticket
    {
        public BoxOffice(string Movie_Name, string Theater_Name, string Show_Time, float No_of_Seat, float Ticket_Price)
        {
            this.Movie_Name = Movie_Name;
            this.Theater_Name = Theater_Name;
            this.Show_Time = Show_Time;
            this.No_of_Seat = No_of_Seat;
            this.Ticket_Price = Ticket_Price;

        }
        public float Booking_Amount { get; set; }
        public override string Calculate_Ticket_Price()
        {
            Booking_Amount = 20;
            float tp = No_of_Seat * Ticket_Price + Booking_Amount;
            return "Total Price ="  +tp.ToString();
        }

    }
}
