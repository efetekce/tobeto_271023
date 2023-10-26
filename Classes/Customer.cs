using System;
namespace Classes
{
    public class Customer
    {
        // when we're assigning values to properties, set method will work.
        public int Id { get; set; }
        private string _FirstName;
        public string FirstName
        {
            get
            {
                return "Mr " + _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}

