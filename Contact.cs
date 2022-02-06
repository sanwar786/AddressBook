namespace AddressBook
{
    internal class Contact
    {
        internal readonly int firstName;
        internal readonly int lastName;
        internal readonly int address;
        internal readonly int city;
        internal readonly object zip;
        internal readonly int state;
        internal readonly int phoneNumber;
        internal readonly int emailId;

        public Contact(string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string emailId)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            EmailId = emailId;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string Address { get; }
        public string City { get; }
        public string State { get; }
        public int Zip { get; }
        public long PhoneNumber { get; }
        public string EmailId { get; }
    }
}