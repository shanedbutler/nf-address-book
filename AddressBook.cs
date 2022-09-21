namespace AddressBookSpace
{
    public class AddressBook
    {
        private Dictionary<string, Contact> _contactList { get; set; } = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            _contactList.Add(contact.Email, contact);
        }
        public Contact GetByEmail(string email)
        {

            return _contactList[email];

        }
    }
}