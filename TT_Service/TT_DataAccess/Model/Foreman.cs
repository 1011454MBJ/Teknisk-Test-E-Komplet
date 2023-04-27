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
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string PhoneNumber { get; set; }
        private string JobTitle { get; set; }
        private List<Fitter> FitterList { get; set; }
        public Foreman()
        {
        }
        public Foreman(string firstName, string lastName, string phoneNumber, string jobTitle)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            JobTitle = jobTitle;
            FitterList = new List<Fitter>();
            
        }
    }
}
