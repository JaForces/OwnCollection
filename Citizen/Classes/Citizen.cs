using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citizen
{
    abstract class Citizen
    {
        private string firstname;
        private string lastname;
        private string passport;


        public string FullInfo()
        {
            return firstname + " " + lastname + " " + passport;
        }
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
       
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Passport
        {
            get { return passport; }
            set { passport = value; }
        }

        public Citizen(string firstname, string lastname, string passport)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.passport = passport;
        }
    }
}
