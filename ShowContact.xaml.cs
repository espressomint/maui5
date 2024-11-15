namespace aplikacjatress
{
    public partial class ShowContact : ContentPage
    {
        public ShowContact()
        {
            InitializeComponent();
            contactsListView.ItemsSource = ContactList.Contacts;
            contactsListView.ItemSelected += OnContactSelected; 
        }

        private void OnContactSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedContact = e.SelectedItem as Contact;
            if (selectedContact != null)
            {
                descriptionLabel.Text = selectedContact.Description;
            }
        }
    }
}
