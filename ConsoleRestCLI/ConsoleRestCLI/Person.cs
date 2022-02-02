using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRestCLI
{
    public class Person
    {
        public long ID { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String PayRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
