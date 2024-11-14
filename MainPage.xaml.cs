namespace aplikacjatress
{
    public partial class MainPage : ContentPage
    {
        //private ContactList contactList;

        public MainPage()
        {
            InitializeComponent();
            //contactList = list;
        }

        private void ContactButtonClicked(object sender, EventArgs e)
        {
            var contact = new Contact
            {
                Name = nameEntry.Text,
                Age = int.Parse(ageEntry.Text),
                Description = descriptionEntry.Text
            };

            ContactList.Contacts.Add(contact);
            nameEntry.Text = string.Empty;
            ageEntry.Text = string.Empty;
            descriptionEntry.Text = string.Empty;
        }

        private void ShowContactsButtonClicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new ShowContact());
        }

    }

}
