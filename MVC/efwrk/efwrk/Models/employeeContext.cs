using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace efwrk.Models
{
    public class employeeContext:DbContext
    {
        //creating Constructor and calling the base class and pass the databasename\
        public employeeContext() : base("EmployeeDB")
        {             
        }
        public DbSet<employee>employees { get; set; }
    }
}