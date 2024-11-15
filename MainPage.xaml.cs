namespace aplikacjatress
{
    public partial class MainPage : ContentPage
    {
        //private ContactList contactList;
        private int nextId = 1;
        public MainPage()
        {
            InitializeComponent();
            //contactList = list;
        }

        private void ContactButtonClicked(object sender, EventArgs e)
        {
            var contact = new Contact
            {
                ID = nextId++,
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
        private async void FilterContactsByAgeButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPage());
        }

    }

}
