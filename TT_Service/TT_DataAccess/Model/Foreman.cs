using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT_DataAccess.Model
{
    /// <summary>
    /// Creates a Foreman object with the following properties:
    /// </summary>
    public class Foreman
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string JobTitle { get; set; }
        public Foreman()
        {
        }
    }
}
