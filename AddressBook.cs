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
            foreach (string contactEmail in _contactList.Keys)
            {
                try
                {
                    if (contactEmail.Contains(email))
                    {
                        return _contactList[contactEmail];
                    }
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }
    }
}