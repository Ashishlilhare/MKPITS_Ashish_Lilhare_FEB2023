using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace enttity2.Models
{
    public class StudentContext : DbContext
    {
        //createing a constructor and calling the base Class constrctor and passing the databse name 

        public StudentContext() : base("StudentDatabase")
        {
        }
            //creating property
            public DbSet<Student> Students { get; set; }   
    }
}