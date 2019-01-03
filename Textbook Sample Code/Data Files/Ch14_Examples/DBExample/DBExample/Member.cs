// Member.cs
// This class includes private members of
// identification number, first and last
// names and local phone number. Read-only
// properties are included. The ToString( )
// method is overridden to return a formatted 
// full name 

using System;

namespace DBExample
{
    class Member
    {
        private string id;
        private string firstName;
        private string lastName;
        private string phoneNumber;

        // Constructors
        public Member()
        {

        }

        public Member(string fname, string lname)
        {
            firstName = fname;
            lastName = lname;

        }

        // Properties
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}