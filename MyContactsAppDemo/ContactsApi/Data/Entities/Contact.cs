namespace ContactsApi.Data
{
    using System;
    using System.Collections.Generic;

    public class Contact
    {
        public Contact()
        {
            Emails = new List<Email>();
            PhoneNumbers = new List<PhoneNumber>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Email> Emails  { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
    }
}
